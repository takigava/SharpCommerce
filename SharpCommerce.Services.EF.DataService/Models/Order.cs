using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderCurrency = new HashSet<OrderCurrency>();
            OrderedCart = new HashSet<OrderedCart>();
        }

        public int OrderId { get; set; }
        public int ShippingMethodId { get; set; }
        public int PaymentMethodId { get; set; }
        public double? OrderDiscount { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string CustomerComment { get; set; }
        public string StatusComment { get; set; }
        public string AdminComment { get; set; }
        public decimal? ShippingCost { get; set; }
        public decimal? TaxCost { get; set; }
        public decimal? SupplyTotal { get; set; }
        public decimal Sum { get; set; }
        public int OrderStatusId { get; set; }
        public int ShippingContactId { get; set; }
        public string PaymentMethodName { get; set; }
        public string ShippingMethodName { get; set; }
        public int OrderContactId { get; set; }
        public Guid? CustomerId { get; set; }

        public virtual ICollection<OrderCurrency> OrderCurrency { get; set; }
        public virtual ICollection<OrderedCart> OrderedCart { get; set; }
        public virtual OrderContact OrderContact { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual ShippingContact ShippingContact { get; set; }
        public virtual ShippingMethod ShippingMethod { get; set; }
    }
}
