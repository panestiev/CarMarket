namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class AgriculturalViewModel : MachineViewModel
    {
        [Required]
        [Display(Name = "Category")] //moto AND truck AND AGRO
        public string Category { get; set; }

        internal void Update()
        {
            this.Fuel = CarMarket.Web.Models.MachineModel.Fuel.FuelList[this.Fuel];
        }
    }
}