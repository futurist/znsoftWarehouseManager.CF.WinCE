﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace СкладскойУчет
{
    public partial class ФормаВыборФилиалаТерминал : Form
    {
        private Пакеты Обмен;
        private string[][] ОтветСервера;

        private string НомерТС;

        private string ТТННомер;
        private string ТТНСсылка;

        public ФормаВыборФилиалаТерминал(string _НомерТС, string _ТТННомер, string _ТТНСсылка)
        {
            InitializeComponent();
            
            Обмен     = new Пакеты("ПогрузкаАвтоТерминал");
            НомерТС   = _НомерТС;
            ТТННомер  = _ТТННомер;
            ТТНСсылка = _ТТНСсылка;
        }


        private void ФормаВыборФилиалаТерминал_Load(object sender, EventArgs e)
        {
            // заполним подсказку пользователю

            ПодсказкаПользователю.Text = НомерТС + "\nВЫБЕРИТЕ ФИЛИАЛ ПОГРУЗКИ";

            // получить список филиалов по ТТН

            Cursor.Current = Cursors.WaitCursor;
            ОтветСервера = Обмен.ПослатьСтроку("ВыборФилиалаПолучитьСписокФилиалов", ТТНСсылка);
            Cursor.Current = Cursors.Default;

            if (ОтветСервера == null)
            { return; }

            // заполним список Филиалов

            try
            {
                foreach (string[] str in ОтветСервера)
                {
                    string[] row = { str[0], str[1], str[2] };
                    ListViewItem НоваяСтрока = СписокФилиалов.Items.Add(new ListViewItem(row));

                    if (Convert.ToInt32(НоваяСтрока.SubItems[2].Text) > 0)
                    {
                        НоваяСтрока.BackColor = Color.LightGreen; 
                    }
                }
            }
            catch
            {
                Инфо.Ошибка("Нет филиалов на погрузку.");
                this.Close();
                return;
            }

            // установим курсор в первую строку

            if (СписокФилиалов.Items.Count > 0)
            {
                СписокФилиалов.Focus();

                СписокФилиалов.Items[0].Focused = true;
            }


        }

        private void ФормаВыборФилиалаТерминал_KeyDown(object sender, KeyEventArgs e)
        {
            if (РаботаСоСканером.НажатаКлавишаСкан(e))
            {
                // ничего не делаем
            }

            if (РаботаСоСканером.НажатаПраваяПодэкраннаяКлавиша(e) || (e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                Cursor.Current = Cursors.WaitCursor;
                _Далее();
                Cursor.Current = Cursors.Default;
            }

            if (РаботаСоСканером.НажатаЛеваяПодэкраннаяКлавиша(e) || (e.KeyCode == System.Windows.Forms.Keys.Escape))
            {
                Cursor.Current = Cursors.WaitCursor;
                _Назад();
                Cursor.Current = Cursors.Default;
            }
        } 


        private void Далее_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _Далее();
            Cursor.Current = Cursors.Default;
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _Назад();
            Cursor.Current = Cursors.Default;
        }

        public virtual void _Назад()
        {
            // переходим в форму выбора ТТН
 
            Form Окно = new ФормаВыборТТНТерминал();
            Окно.Show();
            
            this.Close();

            return;
        }

        public virtual void _Далее()
        {
            // переходим в форму погрузки

            ListViewItem ТекущаяСтрока = СписокФилиалов.FocusedItem;

            if (ТекущаяСтрока == null)
            {
                return;
            }

            Form Окно = new ФормаПогрузкаТерминал(НомерТС, ТТННомер, ТТНСсылка, ТекущаяСтрока.SubItems[0].Text, ТекущаяСтрока.SubItems[1].Text);
            Окно.Show();
 
            this.Close();

            return;
        }

    }
}