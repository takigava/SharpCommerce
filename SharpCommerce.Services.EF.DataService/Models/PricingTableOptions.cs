using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class PricingTableOptions
    {
        public int PricingTableOptionId { get; set; }
        public int PricingTableId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual PricingTable PricingTable { get; set; }
    }
}
