namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class VehiculeViewModel : MachineViewModel
    {
        [Display(Name = "Cubage", Order = 10)]
        public int Cubage { get; set; }

        [Required]
        [Display(Name = "Gear", Order = 8)]
        public string Gear { get; set; }

        [Required]
        [Display(Name = "Km", Order = 6)]
        public int Km { get; set; }
    }
}