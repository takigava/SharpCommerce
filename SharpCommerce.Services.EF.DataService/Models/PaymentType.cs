using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            PaymentMethod = new HashSet<PaymentMethod>();
        }

        public int PaymentTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PaymentMethod> PaymentMethod { get; set; }
    }
}
