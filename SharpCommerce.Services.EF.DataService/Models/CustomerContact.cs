using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class CustomerContact
    {
        public int ContactId { get; set; }
        public Guid? CustomerId { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }
        public int? RegionId { get; set; }
        public string City { get; set; }
        public int? CityId { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Zip { get; set; }
        public bool? Main { get; set; }

        public virtual City CityNavigation { get; set; }
        public virtual Country Country { get; set; }
        public virtual Region Region { get; set; }
    }
}
