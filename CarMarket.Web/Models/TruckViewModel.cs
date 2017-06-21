namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class TruckViewModel : VehiculeViewModel
    {
        [Required]
        [Display(Name = "Category")] //moto AND truck AND AGRO
        public string Category { get; set; }

        [Required]
        [Display(Name = "Axle")]
        public string Axle { get; set; }

        [Required]
        [Display(Name = "Cargo")] // Bus AND Truck
        public string Cargo { get; set; }

        [Required]
        [Display(Name = "Color", Order = 12)]        //Car AND BUS AND MOTO AND CAMPER AND TRUCK AND BOAT      
        public string Color { get; set; }

        [Display(Name = "Horse Power", Order = 9)]//Car AND BUS AND MOTO AND CAMPER AND TRUCK AND BOAT AND CONSTRUCT
        public int HorsePower { get; set; }

        [Display(Name = "Air conditioning")]
        public bool AirConditioning { get; set; }

        [Display(Name = "Heated")]
        public bool Heater { get; set; }

        [Display(Name = "Sleeping cabin")]
        public bool SleepingCabin { get; set; }

        [Display(Name = "ASD")]
        public bool ASD { get; set; }

        [Display(Name = "ASR")]
        public bool Asr { get; set; }

        [Display(Name = "Airbag")]
        public bool Airbag { get; set; }

        [Display(Name = "ABS")]
        public bool Abs { get; set; }

        [Display(Name = "Halogen Headlights")]
        public bool HalogenHeadlights { get; set; }

        [Display(Name = "Retarder")]
        public bool Retarder { get; set; }

        [Display(Name = "Alarm")]
        public bool Alarm { get; set; }

        [Display(Name = "Winch")]
        public bool Winch { get; set; }

        [Display(Name = "Rod")]
        public bool Rod { get; set; }

        [Display(Name = "Refrigerated")]
        public bool Refrigerated { get; set; }

        [Display(Name = "4x4")]
        public bool FourXFour { get; set; }

        [Display(Name = "Central locking")]
        public bool CentralLocking { get; set; }

        [Display(Name = "EPD")]
        public bool EPD { get; set; }

        [Display(Name = "EPS")]
        public bool EPS { get; set; }

        [Display(Name = "Insurance")]
        public bool Insurance { get; set; }
    }
}