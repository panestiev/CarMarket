namespace CarMarket.Web.Models.CamperModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class Heat
    {
        public static readonly Dictionary<string, string> HeatList = new Dictionary<string, string>
        {
            { "1", "Няма" },
            { "2", "Електричество" },
            { "3", "Газ/Бензин" }
        };
    }
}