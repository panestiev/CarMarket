﻿namespace CarMarket.Web.Models.MachineModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class Months
    {
        public static readonly Dictionary<string, string> MonthsList = new Dictionary<string, string>
        {
            { "01", "January" },
            { "02", "February" },
            { "03", "March" },
            { "04", "April" },
            { "05", "May" },
            { "06", "June" },
            { "07", "July" },
            { "08", "August" },
            { "09", "September" },
            { "10", "October" },
            { "11", "November" },
            { "12", "December" }
        };
    }
}