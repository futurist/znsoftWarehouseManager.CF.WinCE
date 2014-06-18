﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using СкладскойУчет.СсылкаНаСервис;
namespace СкладскойУчет
{
    class Пакеты
    {
        public СоединениеВебСервис Соединение;
        public List<СтрокаНоменклатуры> Список = new List<СтрокаНоменклатуры>();
        public СтрокаНоменклатуры[] СписокСтрок;
        public СтрокаНоменклатуры[] ОтветСервера;
        public string Операция;
        
        public Пакеты(string операция) {

            this.Операция = операция;
            Соединение = СоединениеВебСервис.ПолучитьСервис();
        }

        public СтрокаНоменклатуры[] ПодготовитьСтроку(string Код, string Наименование, int Количество)
        {
            СписокСтрок = new СтрокаНоменклатуры[1]{new СтрокаНоменклатуры()};
            СписокСтрок[0].Код = Код;
            СписокСтрок[0].Наименование = Наименование;
            СписокСтрок[0].Количество = String.Format("{0}", Количество);
            return СписокСтрок;
        }

        public СтрокаНоменклатуры[] Послать()
        {
                ОтветСервера = Соединение.Сервис.ОбменТСД(Операция, СписокСтрок);
            return ОтветСервера;

        }

        public СтрокаНоменклатуры[] ПослатьСтроку(string Код, string Наименование, int Количество)
        {
            ПодготовитьСтроку(Код, Наименование, Количество);
            return Послать();
        }

        //СтрокаНоменклатуры = new СсылкаНаСервис.СтрокаНоменклатуры();
        //СтрокаНоменклатуры.Код = "423";
        //СтрокаНоменклатуры.Количество = "503";
        //СтрокаНоменклатуры.Наименование = "123";
        //List<СсылкаНаСервис.СтрокаНоменклатуры> Список = new List<СкладскойУчет.СсылкаНаСервис.СтрокаНоменклатуры>();
        //Список.Add(СтрокаНоменклатуры);
        //return Список.ToArray();
        //СсылкаНаСервис.СтрокаНоменклатуры[] СписокПользователей = Сервис.ОбменТСД("СписокПользователей",Список.ToArray());

        //List<СсылкаНаСервис.СтрокаНоменклатуры> Список = new List<СкладскойУчет.СсылкаНаСервис.СтрокаНоменклатуры>();
        //СсылкаНаСервис.СтрокаНоменклатуры СтрокаНоменклатуры = new СсылкаНаСервис.СтрокаНоменклатуры();
        //СтрокаНоменклатуры.Код = "423";
        //СтрокаНоменклатуры.Количество = "503";
        //СтрокаНоменклатуры.Наименование = "123";
        //Список.Add(СтрокаНоменклатуры);
        //var Список = Пакеты.ПодготовитьСтроку("123", "123", "123");
        //СсылкаНаСервис.СтрокаНоменклатуры[] СписокПользователей = Сервис.ОбменТСД("СписокПользователей", Список);
        //СсылкаНаСервис.СтрокаНоменклатуры[] СписокПользователей = Сервис.ОбменТСД("СписокПользователей",Список.ToArray());



    }
}
