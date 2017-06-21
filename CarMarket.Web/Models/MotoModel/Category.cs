namespace CarMarket.Web.Models.MotoModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class Category
    {
        public static readonly Dictionary<string, string> CategoryList = new Dictionary<string, string>
        {
            { "1", "ATV" },
            { "2", "Бъги" },
            { "3", "Ендуро" },
            { "4", "Моторна шейна" },
            { "5", "Кросов" },
            { "6", "Пистов" },
            { "7", "Скутер" },
            { "8", "Турър" },
            { "9", "Чопър" },
            { "10", "Супер Мото" },
            { "11", "Картинг" },
            { "12", "Триколка" } 
        };
    }
}