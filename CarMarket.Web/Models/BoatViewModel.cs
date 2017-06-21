namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class BoatViewModel : MachineViewModel
    {
        [Required]
        [Display(Name = "Type")] //BUSS AND CAMPER AND Boat
        public string Type { get; set; }

        [Required]
        [Display(Name = "Number of Engines")]
        public string NumberOfEngines { get; set; }

        [Required]
        [Display(Name = "Hours of operation")]
        public int HoursOfOperation { get; set; }

        [Required]
        [Display(Name = "Material")]
        public string Material { get; set; }

        [Required]
        [Display(Name = "Length")] // Camper AND BOAT
        public string Length { get; set; }

        [Required]
        [Display(Name = "Width")]
        public string Width { get; set; }

        [Required]
        [Display(Name = "Wade")]
        public string Wade { get; set; }
        [Required]
        [Display(Name = "Color", Order = 12)]        //Car AND BUS AND MOTO AND CAMPER AND TRUCK AND BOAT      
        public string Color { get; set; }

        [Display(Name = "Horse Power", Order = 9)]//Car AND BUS AND MOTO AND CAMPER AND TRUCK AND BOAT AND CONSTRUCT
        public int HorsePower { get; set; }

        public bool Climat { get; set; }

        public bool Insurance { get; set; }

        public bool Radar { get; set; }

        public bool NavigationSystem { get; set; }
    }
}