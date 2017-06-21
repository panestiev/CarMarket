namespace CarMarket.Web.Models.TruckModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class Category
    {
        public static readonly Dictionary<string, string> CategoryList = new Dictionary<string, string>
        {
            { "1", "Автовоз" },
            { "2", "Бордови" },
            { "3", "Влекач" },
            { "4", "Кран" },
            { "5", "Мултилифт" },
            { "6", "Самосвал" },
            { "7", "Фургон" },
            { "8", "Цистерна" },
            { "9", "Сметовоз" },
            { "10", "Хенгер" },
            { "11", "Хладилен" }
        };
    }
}