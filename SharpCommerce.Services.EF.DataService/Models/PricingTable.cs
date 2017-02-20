using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class PricingTable
    {
        public PricingTable()
        {
            PricingTableOptions = new HashSet<PricingTableOptions>();
        }

        public int PricingTableId { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? PricingPeriodId { get; set; }
        public int CurrencyId { get; set; }

        public virtual ICollection<PricingTableOptions> PricingTableOptions { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual PricingPeriod PricingPeriod { get; set; }
    }
}
