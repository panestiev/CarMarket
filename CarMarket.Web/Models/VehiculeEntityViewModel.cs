namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    // TODO Vehicle
    public class VehiculeEntityViewModel : MachineEntityViewModel
    {
        public int Cubage { get; set; }

        public string Gear { get; set; }

        public int Km { get; set; }
    }
}