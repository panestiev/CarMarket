namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class CamperEntityViewModel : VehiculeEntityViewModel
    {
        public string Type { get; set; }

        public int NumberOfBerths { get; set; }

        public string Heat { get; set; }

        public string Length { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

        public bool AirCondition { get; set; }

        public bool Insurance { get; set; }

        public bool TvDvd { get; set; }

        public bool WC { get; set; }

        public bool SolarEnergySystem { get; set; }
    }
}