namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class MachineEntityViewModel
    {
        [Key]
        public int MachineId { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public string SellerName { get; set; }

        public string SellerTelephone { get; set; }

        public string[] ImageVirtualPaths { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Modification { get; set; }

        public int Price { get; set; }

        public string Fuel { get; set; }

        public DateTime YearOfManufacture { get; set; }

        public string Months { get; set; }

        public string Years { get; set; }

        public string MoreInformation { get; set; }

        public MachineryTypeEnum MachineType { get; set; }
    }
}