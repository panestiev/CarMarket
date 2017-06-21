namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class BoatEntityViewModel : MachineEntityViewModel
    {
        public string Type { get; set; }

        public string NumberOfEngines { get; set; }

        public int HoursOfOperation { get; set; }

        public string Material { get; set; }

        public string Length { get; set; }

        public string Width { get; set; }

        public string Wade { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

        public bool Climat { get; set; }

        public bool Insurance { get; set; }

        public bool Radar { get; set; }

        public bool NavigationSystem { get; set; }
    }
}