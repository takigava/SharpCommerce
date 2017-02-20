using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class PricingPeriod
    {
        public PricingPeriod()
        {
            PricingTable = new HashSet<PricingTable>();
        }

        public int PricingPeriodId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<PricingTable> PricingTable { get; set; }
    }
}
