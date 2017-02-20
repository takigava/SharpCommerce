using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class OrderedCart
    {
        public int OrderedCartId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public string ArtNo { get; set; }
        public decimal? SupplyPrice { get; set; }
        public double? Weight { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
