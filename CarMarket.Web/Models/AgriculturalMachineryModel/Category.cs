﻿namespace CarMarket.Web.Models.AgriculturalMachineryModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class Category
    {
        public static readonly Dictionary<string, string> CategoryList = new Dictionary<string, string>
        {
            { "1", "Трактори" }, 
            { "2", "Комбайни" }, 
            { "3", "Прикачен инвентар" },
            { "4", "Мотоблокове" },
            { "5", "Напоителни системи" },
            { "6", "Посадъчна техника" },
            { "7", "Наторителна техника" },
            { "8", "Помпи" },
            { "9", "Сеносъбирачи, Сенообръщачки" },
            { "10", "Машини за зърнопроизводство" },
            { "11", "Машини за лозя/овошки" },
            { "12", "Машини за зеленчукови градини" },
            { "13", "Машини за животновъдни ферми" },
            { "14", "Машини за рибовъдство и аквакултури" },
            { "15", "Горски машини и техника" },
            { "16", "Градинска техника/косачки" },
            { "17", "Други" }
        };
    }
}