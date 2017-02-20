using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class PaymentParam
    {
        public int PaymentParamId { get; set; }
        public int PaymentMethodId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
