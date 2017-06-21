namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class MotoEntityViewModel : VehiculeEntityViewModel
    {
        public string Category { get; set; }

        public string TypeOfEngine { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

        public bool Alarm { get; set; }

        public bool Immobilizer { get; set; }

        public bool Abs { get; set; }

        public bool AirCushion { get; set; }

        public bool NavigationSystem { get; set; }

        public bool AutoStarter { get; set; }

        public bool Insurance { get; set; }

        public bool ServiceBook { get; set; }

        public bool ProtectiveGlass { get; set; }
    }
}