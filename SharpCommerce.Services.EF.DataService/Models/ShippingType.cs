using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ShippingType
    {
        public ShippingType()
        {
            ShippingMethod = new HashSet<ShippingMethod>();
        }

        public int ShippingTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ShippingMethod> ShippingMethod { get; set; }
    }
}
