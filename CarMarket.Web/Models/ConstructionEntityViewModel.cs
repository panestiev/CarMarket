namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class ConstructionEntityViewModel : MachineEntityViewModel
    {
        public string Type { get; set; }

        public int Km { get; set; }

        public int HoursOfOperation { get; set; }

        public string Displacement { get; set; }

        public string CarryingCapacity { get; set; }

        public string WorkingHeight { get; set; }

        public string Axle { get; set; }

        public string Operation { get; set; }

        public string TotalWeight { get; set; }

        public int HorsePower { get; set; }
    }
}