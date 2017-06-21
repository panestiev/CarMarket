namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class CarEntityViewModel : VehiculeEntityViewModel
    {
        public string Carriage { get; set; }

        public string Color { get; set; }

        public string NumberOfDoors { get; set; }

        public string EuroStandart { get; set; }

        public int HorsePower { get; set; }

        public bool AirConditioning { get; set; }

        public bool JustClimate { get; set; }

        public bool LeatherSeats { get; set; }

        public bool PowerWindows { get; set; }

        public bool ElectricMirrors { get; set; }

        public bool PowerSeats { get; set; }

        public bool HeatedSeats { get; set; }

        public bool Sunroof { get; set; }

        public bool Stereo { get; set; }

        public bool AlloyWheels { get; set; }

        public bool Dvd { get; set; }

        public bool MultifunctionalSteeringWheel { get; set; }

        public bool FourXFour { get; set; }

        public bool Abs { get; set; }

        public bool Esp { get; set; }

        public bool Airbag { get; set; }

        public bool XenonLights { get; set; }

        public bool HalogenHeadlights { get; set; }

        public bool Asr { get; set; }

        public bool Parktronic { get; set; }

        public bool Alarm { get; set; }

        public bool Immobilizer { get; set; }

        public bool CentralLocking { get; set; }

        public bool Insurance { get; set; }

        public bool Armored { get; set; }

        public bool StartStopSystem { get; set; }

        public bool KeylessIgnition { get; set; }

        public bool Tiptronic { get; set; }

        public bool Autopilot { get; set; }

        public bool PowerSteering { get; set; }

        public bool TripComputer { get; set; }

        public bool ServiceBook { get; set; }

        public bool Guaranty { get; set; }

        public bool NavigationSystem { get; set; }

        public bool Tuning { get; set; }

        public bool PanoramicRoof { get; set; }

        public bool Taxi { get; set; }

        public bool Retro { get; set; }

        public bool Rod { get; set; }

        public bool Places { get; set; }

        public bool Refrigerated { get; set; }
    }
}