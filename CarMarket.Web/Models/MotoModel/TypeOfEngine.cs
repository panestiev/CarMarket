namespace CarMarket.Web.Models.MotoModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class TypeOfEngine
    {
        public static readonly Dictionary<string, string> TypeOfEngineList = new Dictionary<string, string>
        {
            { "1", "Двутактов" },
            { "2", "Четиритактов" }
        };
    }
}