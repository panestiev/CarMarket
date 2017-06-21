namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class Images
    {
        [Key]
        public int ImagesId { get; set; }

        public string BusID { get; set; }

        public virtual BusEntityViewModel Buses { get; set; }

        public string CarID { get; set; }

        public virtual CarEntityViewModel Cars { get; set; }
    }
}