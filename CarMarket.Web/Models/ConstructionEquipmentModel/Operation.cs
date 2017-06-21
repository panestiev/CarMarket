namespace CarMarket.Web.Models.ConstructionEquipmentModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class Operation
    {
        public static readonly Dictionary<string, string> OperationList = new Dictionary<string, string>
        {
            { "1", "Колесно" },
            { "2", "Верижно" }
        };
    }
}