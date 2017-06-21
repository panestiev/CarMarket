namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class ConstructionViewModel : MachineViewModel
    {
        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Km", Order = 6)]   //Car AND BUS AND MOTO AND CAMPER AND TRUCK and construct                 
        public int Km { get; set; }

        [Required]
        [Display(Name = "Hours of operation")]
        public int HoursOfOperation { get; set; }

        [Display(Name = "Displacement")]
        public string Displacement { get; set; }

        [Display(Name = "Carrying capacity")]
        public string CarryingCapacity { get; set; }

        [Display(Name = "Working height")]
        public string WorkingHeight { get; set; }

        [Display(Name = "Axles")]
        public string Axle { get; set; }

        [Display(Name = "Operation")]
        public string Operation { get; set; }

        [Display(Name = "Total weight")]
        public string TotalWeight { get; set; }

        [Display(Name = "Horse Power", Order = 9)]//Car AND BUS AND MOTO AND CAMPER AND TRUCK AND BOAT AND CONSTRUCT
        public int HorsePower { get; set; }
    }
}