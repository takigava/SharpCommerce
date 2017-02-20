using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ShippingParam
    {
        public int ShippingParamId { get; set; }
        public int ShippingMethodId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual ShippingMethod ShippingMethod { get; set; }
    }
}
