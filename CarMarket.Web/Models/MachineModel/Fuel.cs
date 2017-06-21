﻿namespace CarMarket.Web.Models.MachineModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class Fuel
    {
        public static readonly Dictionary<string, string> FuelList = new Dictionary<string, string>
        {
           { "1", "Бензин" },
           { "2", "Дизел" },
           { "3", "Газ/Бензин" },
           { "4", "Метан/Бензин" },
           { "5", "Хибрид" },
           { "6", "Електричество" },
        };
    }
}