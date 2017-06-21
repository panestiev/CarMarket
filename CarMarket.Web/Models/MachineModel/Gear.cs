namespace CarMarket.Web.Models.MachineModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class Gear
    {
        public static readonly Dictionary<string, string> GearList = new Dictionary<string, string>
        {
            { "1", "Ръчни" },
            { "2", "Автоматични" },
        };
    }
}