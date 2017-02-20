using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Currency
    {
        public Currency()
        {
            PricingTable = new HashSet<PricingTable>();
        }

        public int CurrencyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double? CurrencyValue { get; set; }
        public string CurrencyIso { get; set; }
        public bool? IsMainCurrency { get; set; }

        public virtual ICollection<PricingTable> PricingTable { get; set; }
    }
}
