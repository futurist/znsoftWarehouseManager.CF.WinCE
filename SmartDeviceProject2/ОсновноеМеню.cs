﻿//#define class Класс  //;

using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Reflection;



namespace СкладскойУчет
{
    public partial class ОсновноеМеню : Form
    {
        public ОсновноеМеню()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }




        private void ОсновноеМеню_Load(object sender, EventArgs e)
        {
            var Авторизован = (NetworkCredential)СоединениеВебСервис.ПолучитьСервис().Сервис.Credentials;
            Пользователь.Text = Авторизован.UserName;
        }

        private void ПриНажатииНаКнопку(object sender, EventArgs Аргументы)
        {
            Button Кнопка = (Button)sender;
            MethodInfo method = this.GetType().GetMethod("_" + Кнопка.Name);
            method.Invoke(this, null);
        }



        private void ОсновноеМеню_Closing(object sender, CancelEventArgs e)
        {
        }

        private void ОсновноеМеню_Closed(object sender, EventArgs e)
        {

            new Пакеты("ТСД").ПослатьСтроку("Выход", "Выход", 123);
        }
        
        private void ОсновноеМеню_KeyDown(object sender, KeyEventArgs e)
        {

            foreach (var ЭлементФормы in Панель_ОсновногоМеню.Controls)
                if (ЭлементФормы is Button)
                {
                    Button Кнопка = (Button)ЭлементФормы;
                    if ((char)Кнопка.Text[0] == (char)e.KeyValue)
                    {
                        Кнопка.Focus();
                        ПриНажатииНаКнопку(Кнопка, new EventArgs());
                        return;
                    }
                }



            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        public void _Выход()
        {
            Выход.Enabled = false;
            Выход.Text = "Отключение...";
            this.Close();
        }

        public void _Перемещение()
        {




        }

        public void _Инвентаризация()
        {




        }






    }
}