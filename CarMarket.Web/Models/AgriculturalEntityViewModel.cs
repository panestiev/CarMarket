namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class AgriculturalEntityViewModel : MachineEntityViewModel
    {
        public string Category { get; set; }
    }
}