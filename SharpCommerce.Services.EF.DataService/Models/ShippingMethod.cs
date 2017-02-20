using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ShippingMethod
    {
        public ShippingMethod()
        {
            Order = new HashSet<Order>();
            ShippingParam = new HashSet<ShippingParam>();
        }

        public int ShippingMethodId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Enabled { get; set; }
        public int? SortOrder { get; set; }
        public int? ShippingType { get; set; }

        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<ShippingParam> ShippingParam { get; set; }
        public virtual ShippingType ShippingTypeNavigation { get; set; }
    }
}
