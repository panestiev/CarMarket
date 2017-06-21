namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class MachineCollection
    {
        public System.Collections.IEnumerable List { get; set; }

        public Type DataType { get; set; }
    }
}