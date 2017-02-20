using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class OrderCurrency
    {
        public int OrderCurrencyId { get; set; }
        public int OrderId { get; set; }
        public string CurrencyCode { get; set; }
        public double? CurrencyValue { get; set; }

        public virtual Order Order { get; set; }
    }
}
