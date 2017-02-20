using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Order = new HashSet<Order>();
            PaymentParam = new HashSet<PaymentParam>();
        }

        public int PaymentMethodId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Enabled { get; set; }
        public int? SortOrder { get; set; }
        public int? PaymentTypeId { get; set; }

        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<PaymentParam> PaymentParam { get; set; }
        public virtual PaymentType PaymentType { get; set; }
    }
}
