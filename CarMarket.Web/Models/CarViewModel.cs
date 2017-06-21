namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class CarViewModel : VehiculeViewModel
    {
        [Required]
        [Display(Name = "Carriage")]
        public string Carriage { get; set; }

        [Required]
        [Display(Name = "Color", Order = 12)]        //Car AND BUS AND MOTO AND CAMPER AND TRUCK AND BOAT      
        public string Color { get; set; }

        [Required]
        [Display(Name = "Number of doors", Order = 11)]      //Car AND BUS  
        public string NumberOfDoors { get; set; }

        [Required]
        [Display(Name = "Euro standart")]         //Car AND BUS             
        public string EuroStandart { get; set; }

        [Display(Name = "Horse Power", Order = 9)]//Car AND BUS AND MOTO AND CAMPER AND TRUCK AND BOAT AND CONSTRUCT
        public int HorsePower { get; set; }

        [Display(Name = "Air conditioning")]
        public bool AirConditioning { get; set; }

        [Display(Name = "Climate")]
        public bool JustClimate { get; set; }

        [Display(Name = "Leather seats")]
        public bool LeatherSeats { get; set; }

        [Display(Name = "Power windows")]
        public bool PowerWindows { get; set; }

        [Display(Name = "Electric mirrors")]
        public bool ElectricMirrors { get; set; }

        [Display(Name = "Power seats")]
        public bool PowerSeats { get; set; }

        [Display(Name = "Heated seats")]
        public bool HeatedSeats { get; set; }

        [Display(Name = "Sunroof")]
        public bool Sunroof { get; set; }

        [Display(Name = "Stereo")]
        public bool Stereo { get; set; }

        [Display(Name = "Alloy wheels")]
        public bool AlloyWheels { get; set; }

        [Display(Name = "Dvd")]
        public bool Dvd { get; set; }

        [Display(Name = "Multifuncional steering wheel")]
        public bool MultifunctionalSteeringWheel { get; set; }

        [Display(Name = "4x4")]
        public bool FourXFour { get; set; }

        [Display(Name = "ABS")]
        public bool Abs { get; set; }

        [Display(Name = "ESP")]
        public bool Esp { get; set; }

        [Display(Name = "Airbag")]
        public bool Airbag { get; set; }

        [Display(Name = "Xenon lights")]
        public bool XenonLights { get; set; }

        [Display(Name = "Halogen Headlights")]
        public bool HalogenHeadlights { get; set; }

        [Display(Name = "ASR")]
        public bool Asr { get; set; }

        [Display(Name = "Parktronic")]
        public bool Parktronic { get; set; }

        [Display(Name = "Alarm")]
        public bool Alarm { get; set; }

        [Display(Name = "Immobilizer")]
        public bool Immobilizer { get; set; }

        [Display(Name = "Center locking")]
        public bool CentralLocking { get; set; }

        [Display(Name = "Insurance")]
        public bool Insurance { get; set; }

        [Display(Name = "Armored")]
        public bool Armored { get; set; }

        [Display(Name = "Start-Stop system")]
        public bool StartStopSystem { get; set; }

        [Display(Name = "Keyless Ignition")]
        public bool KeylessIgnition { get; set; }

        [Display(Name = "Tiptronic")]
        public bool Tiptronic { get; set; }

        [Display(Name = "Autopilot")]
        public bool Autopilot { get; set; }

        [Display(Name = "Power Steering")]
        public bool PowerSteering { get; set; }

        [Display(Name = "Trip computer")]
        public bool TripComputer { get; set; }

        [Display(Name = "Service book")]
        public bool ServiceBook { get; set; }

        [Display(Name = "Guaranty")]
        public bool Guaranty { get; set; }

        [Display(Name = "Navigation system")]
        public bool NavigationSystem { get; set; }

        [Display(Name = "Tuning")]
        public bool Tuning { get; set; }

        [Display(Name = "Panoramic roof")]
        public bool PanoramicRoof { get; set; }

        [Display(Name = "Taxi")]
        public bool Taxi { get; set; }

        [Display(Name = "Retro")]
        public bool Retro { get; set; }

        [Display(Name = "Rod")]
        public bool Rod { get; set; }

        [Display(Name = "Places")]
        public bool Places { get; set; }

        [Display(Name = "Refrigerated")]
        public bool Refrigerated { get; set; }
    }
}