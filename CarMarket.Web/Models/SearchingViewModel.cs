namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class SearchingViewModel
    {
        public string Model { get; set; }

        public string Brand { get; set; }

        public string Fuel { get; set; }

        public string Gear { get; set; }

        public string Carriage { get; set; }

        public string Type { get; set; }

        public string Category { get; set; }

        public string NumberOfDoors { get; set; }

        public int? Price { get; set; }

        public MachineryTypeEnum MachineType { get; set; }
    }
}