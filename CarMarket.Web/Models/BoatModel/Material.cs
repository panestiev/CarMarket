namespace CarMarket.Web.Models.BoatModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class Material
    {
        public static readonly Dictionary<string, string> MaterialList = new Dictionary<string, string>
        {
            { "1", "Желязо" },
            { "2", "Пластмаса" },
            { "3", "Дърво" },
            { "4", "Бетон" },
            { "5", "Кевлар" },
            { "6", "PVC" },
            { "7", "Гума" },
            { "8", "Хипалон" }
        };
    }
}