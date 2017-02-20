using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ShippingContact
    {
        public ShippingContact()
        {
            Order = new HashSet<Order>();
        }

        public int OrderShippingContactId { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Zip { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
