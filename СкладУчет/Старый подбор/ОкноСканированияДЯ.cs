﻿using System;
using System.Windows.Forms;

namespace СкладскойУчет
{
    public partial class ОкноСканированияДЯ : Form
    {

        Пакеты Обмен;
        public int НомерКонокиГУИД = 0;
        ПоследовательностьОкон Последовательность;

        public ОкноСканированияДЯ(ПоследовательностьОкон ПоследовательностьОкон)
        {
            InitializeComponent();
            Последовательность = ПоследовательностьОкон;
            Обмен = new Пакеты(ПоследовательностьОкон.Операция + " ВыборЗадания"); //Сформировали пакет с операцией состоящей например "Подбор ВыборЗадания"
        }

        public virtual void ОкноСканированияДЯ_Load(object sender, EventArgs e)
        {
            СписокВыбора.Focus();
            ЭлементыФормыДляЗаполнения ЭлементыФормы = new ЭлементыФормыДляЗаполнения();
            ЭлементыФормы.Инструкция = this.Инструкция;
            ЭлементыФормы.СписокВыбора = this.СписокВыбора;
            //ЭлементыФормы.ТекстДЯ = this.Пользователь;
            ЭлементыФормы.Пользователь = this.Пользователь;
            ЗаполнениеЭлементовФормы.ЗаполнитьФорму(ЭлементыФормы, ref Последовательность.ОтветСервера, ref НомерКонокиГУИД);

        }

        private void ОкноСканированияДЯ_KeyDown(object sender, KeyEventArgs e)
        {
            if (РаботаСоСканером.НажатаКлавишаСкан(e))
            {
                СканированиеШК(e);
                return;
            }


            if ((e.KeyCode == System.Windows.Forms.Keys.D0)||РаботаСоСканером.НажатаЛеваяПодэкраннаяКлавиша(e))
            {
                _Назад();
            }


            if ((e.KeyCode == System.Windows.Forms.Keys.D1)||(e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                Таб.SelectedIndex = 0;
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.D2)||(e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                Таб.SelectedIndex = 1;
            }


        }

        private void Назад_Click(object sender, EventArgs e)
        {
            _Назад();
        }

        public void _Назад()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();//Нажали назад, необходимо попасть на предыдущее окно, думаю можно и самому решить этот вопрос без обращения к серверу
        }

        private void СканированиеШК(KeyEventArgs e)
        {
            string СтрокаСкан = РаботаСоСканером.Scan();
            if (СтрокаСкан.Length != 0)
            {
                e.Handled = true;
                if (Таб.SelectedIndex == 0)
                {
                    СканАдреса(СтрокаСкан);
                    return;
                }

                Инфо.ПолучениеИнформации(СтрокаСкан, СписокИнформации, Таб);
            }
        }

        public virtual void СканАдреса(string СтрокаСкан)
        {
            Последовательность.ОтветСервера = Обмен.ПослатьСтроку(СтрокаСкан, Последовательность.ТекущееОкно, "СканированВыбор");
            if (Последовательность.ОтветСервера == null) return; // в случае ошибки остаться в этом же окне
            this.DialogResult = DialogResult.Retry;
            this.Close();
            return;
        }

    }
}