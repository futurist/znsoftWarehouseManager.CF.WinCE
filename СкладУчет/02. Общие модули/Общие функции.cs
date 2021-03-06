﻿using System;
using System.Text;
using System.IO;

namespace СкладскойУчет
{
    public class ОбщиеФункции
    {
        public static bool ПроверитьЕАН8(string СтрокаСкан)
        {
            try
            {
                int с1 = int.Parse(СтрокаСкан.Substring(0, 1));
                int с2 = int.Parse(СтрокаСкан.Substring(1, 1));
                int с3 = int.Parse(СтрокаСкан.Substring(2, 1));
                int с4 = int.Parse(СтрокаСкан.Substring(3, 1));
                int с5 = int.Parse(СтрокаСкан.Substring(4, 1));
                int с6 = int.Parse(СтрокаСкан.Substring(5, 1));
                int с7 = int.Parse(СтрокаСкан.Substring(6, 1));
                int КонтрольныйСимвол_ = int.Parse(СтрокаСкан.Substring(7, 1));

                string Сумма = (3 * (с1 + с3 + с5 + с7) + с2 + с4 + с6).ToString();
                Сумма = Сумма.Substring(Сумма.Length - 1, 1); // откидываем десятки

                int КонтрольнаяСумма = int.Parse(Сумма);
                int КонтрольныйСимвол;

                if (КонтрольнаяСумма == 0)
                {
                    КонтрольныйСимвол = 0;          
                }
                else
                {
                    КонтрольныйСимвол = 10 - КонтрольнаяСумма;   
                }

                if (КонтрольныйСимвол == КонтрольныйСимвол_) return true;
                else return false;
            }
            catch (Exception) { return false; }
        }
    }
}
