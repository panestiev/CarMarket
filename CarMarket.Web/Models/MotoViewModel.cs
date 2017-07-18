namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class MotoViewModel : VehiculeViewModel
    {
        [Required]
        [Display(Name = "Category")] //moto AND truck AND AGRO
        public string Category { get; set; }

        [Required]
        [Display(Name = "Type of engine")]
        public string TypeOfEngine { get; set; }

        [Required]
        [Display(Name = "Color", Order = 12)]        //Car AND BUS AND MOTO AND CAMPER AND TRUCK AND BOAT      
        public string Color { get; set; }

        [Display(Name = "Horse Power", Order = 9)]//Car AND BUS AND MOTO AND CAMPER AND TRUCK AND BOAT AND CONSTRUCT
        public int HorsePower { get; set; }

        [Display(Name = "Alarm")]
        public bool Alarm { get; set; }

        [Display(Name = "Immobilizer")]
        public bool Immobilizer { get; set; }

        [Display(Name = "ABS")]
        public bool Abs { get; set; }

        [Display(Name = "Air cushion")]
        public bool AirCushion { get; set; }

        [Display(Name = "Navigation system")]
        public bool NavigationSystem { get; set; }

        [Display(Name = "Auto starter")]
        public bool AutoStarter { get; set; }

        [Display(Name = "Insurance")]
        public bool Insurance { get; set; }

        [Display(Name = "Service book")]
        public bool ServiceBook { get; set; }

        [Display(Name = "Protective glass")]
        public bool ProtectiveGlass { get; set; }

        internal void Update()
        {
            this.Brand = CarMarket.Web.Models.MotoModel.Brand.MotoList[this.Brand];
            this.Fuel = CarMarket.Web.Models.MachineModel.Fuel.FuelList[this.Fuel];
            this.Gear = CarMarket.Web.Models.MachineModel.Gear.GearList[this.Gear];
        }
    }
}