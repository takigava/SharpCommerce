using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class OrderPriceDiscount
    {
        public int OrderPriceDiscountId { get; set; }
        public decimal? PriceStartRange { get; set; }
        public decimal? PriceEndRange { get; set; }
        public double? PriceDiscount { get; set; }
    }
}
