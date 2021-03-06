﻿using System.Linq;
using System.Windows.Forms;


namespace СкладскойУчет
{
    public class ОкноПодтоваркиСписка : ОкноПеремещенияСписка
    {
        public ОкноПодтоваркиСписка(ПоследовательностьОкон ПоследовательностьОкон)
            : base(ПоследовательностьОкон)
        {
            НомерКонокиГУИД = 7;
        }


        public override ListViewItem ДобавитьТоварВСписок(string[][] Ответ)
        {
            return null;
        }


        public override bool ПроверитьКоличество(int Сканировано, int Количество)
        {
            return Сканировано > Количество;
        }

        public override void _Далее()
        {

            DialogResult РезультатОкна = ПолучитьАдресКудаПодтоваривать();
            if (РезультатОкна == DialogResult.Cancel) return;
            string Адрес = (from string[] s in Последовательность.ОтветСервера where s[0] == "ТекстДЯ" select s[1]).FirstOrDefault();
            if (Адрес == null) return;
            СформироватьДокументВ1С(Адрес);
            if (Последовательность.ОтветСервера == null) return;
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private DialogResult ПолучитьАдресКудаПодтоваривать()
        {
            string Адреса = ПолучитьРекомендуемыеАдреса();
            Пакеты Обмен = new Пакеты("Нет операции");
            Последовательность.ОтветСервера = Обмен.ПодготовитьСтроку("ТекстИнструкции", "Необходимо сканировать адрес для перемещения отсканированного товара с " + ТекстДЯ.Text + " на:" + Адреса);
            ОкноСканированияАдреса ОкноАдреса = new ОкноСканированияАдреса(Последовательность);
            ОкноАдреса.ВернутьСкан = true;// не обращаться к вебсервису    
            DialogResult РезультатОкна = ОкноАдреса.ShowDialog();
            return РезультатОкна;
        }

        private string ПолучитьРекомендуемыеАдреса()
        {
            string Адреса = "";
            var arr_Адреса = from ListViewItem l in СписокПеремещения.Items where l.SubItems[1].Text != "0" group l by l.SubItems[5].Text into g orderby g.Key ascending select g.Key;
            foreach (string Адрес in arr_Адреса) Адреса = Адреса + "\n\r " + Адрес;
            return Адреса;
        }

        public override void _Назад()
        {

            var arr_l = from ListViewItem l in СписокПеремещения.Items where l.SubItems[1].Text != "0" select l;
            if (arr_l.Count() > 0)
            {
                var MSGRes = MessageBox.Show("При отмене задания все сканированные товары не будут учитываться! вы хотите отменить задание ?", "Подтоварка", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (MSGRes == DialogResult.No) return;
            }
            Пакеты Обмен = new Пакеты("ОтменитьЗаданиеПодтоварки");
            Обмен.ПослатьСтроку(ТекстДЯ.Text);
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
