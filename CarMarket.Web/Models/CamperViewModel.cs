namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class CamperViewModel : VehiculeViewModel
    {
        [Required]
        [Display(Name = "Type")] //BUSS AND CAMPER AND Boat
        public string Type { get; set; }

        [Required]
        [Display(Name = "Number of berths")]
        public int NumberOfBerths { get; set; }

        [Required]
        [Display(Name = "Heat")]
        public string Heat { get; set; }

        [Display(Name = "Length")]// Camper AND BOAT
        public string Length { get; set; }

        [Required]
        [Display(Name = "Color", Order = 12)]        //Car AND BUS AND MOTO AND CAMPER AND TRUCK AND BOAT      
        public string Color { get; set; }

        [Display(Name = "Horse Power", Order = 9)]//Car AND BUS AND MOTO AND CAMPER AND TRUCK AND BOAT AND CONSTRUCT
        public int HorsePower { get; set; }

        [Display(Name = "Air condition")]
        public bool AirCondition { get; set; }

        [Display(Name = "Insurance")]
        public bool Insurance { get; set; }

        [Display(Name = "Tv/Dvd")]
        public bool TvDvd { get; set; }

        [Display(Name = "Wc")]
        public bool WC { get; set; }

        [Display(Name = "Solar energy system")]
        public bool SolarEnergySystem { get; set; }
    }
}