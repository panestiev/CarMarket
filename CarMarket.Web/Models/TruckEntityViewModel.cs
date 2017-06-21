namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class TruckEntityViewModel : VehiculeEntityViewModel
    {
        public string Category { get; set; }

        public string Axle { get; set; }

        public string Cargo { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

        public bool AirConditioning { get; set; }

        public bool Heater { get; set; }

        public bool SleepingCabin { get; set; }

        public bool ASD { get; set; }

        public bool Asr { get; set; }

        public bool Airbag { get; set; }

        public bool Abs { get; set; }

        public bool HalogenHeadlights { get; set; }

        public bool Retarder { get; set; }

        public bool Alarm { get; set; }

        public bool Winch { get; set; }

        public bool Rod { get; set; }

        public bool Refrigerated { get; set; }

        public bool FourXFour { get; set; }

        public bool CentralLocking { get; set; }

        public bool EPD { get; set; }

        public bool EPS { get; set; }

        public bool Insurance { get; set; }
    }
}