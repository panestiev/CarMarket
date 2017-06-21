namespace CarMarket.Web.Models.BusModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class Type
    {
        public static readonly Dictionary<string, string> TypeList = new Dictionary<string, string>
        {   
            { "1", "Пътнически" },
            { "2", "Товарен" },
            { "3", "Товаропътнически" },
            { "4", "Автобус" },
            { "5", "Автовоз" }
        };
    }
}