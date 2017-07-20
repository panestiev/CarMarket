namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class MachineViewModel
    {
        [Key]
        public int MachineId { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        [Display(Name = "Seller")]
        public string SellerName { get; set; }

        [Display(Name = "Telephone")]
        public string SellerTelephone { get; set; }

        public string[] ImageVirtualPaths { get; set; }

        [Required]
        [Display(Name = "Brand", Order = 1)]
        public string Brand { get; set; }

        [Required]
        [Display(Name = "Model", Order = 2)]
        public string Model { get; set; }

        [Display(Name = "Modification", Order = 3)]
        public string Modification { get; set; }

        [Required]
        [Display(Name = "Price", Order = 4)]
        public int Price { get; set; }

        [Required]
        [Display(Name = "Fuel", Order = 7)]
        public string Fuel { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Year of manufacture", Order = 5)]
        public DateTime YearOfManufacture { get; set; }

        [Required]
        [Display(Name = "Month")]
        public string Months { get; set; }

        [Required]
        [Display(Name = "Year")]
        public string Years { get; set; }

        [Display(Name = "More information")]
        public string MoreInformation { get; set; }

        [Required]
        public MachineryTypeEnum MachineType { get; set; }
    }
}