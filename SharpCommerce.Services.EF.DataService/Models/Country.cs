using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
            CustomerContact = new HashSet<CustomerContact>();
            Profile = new HashSet<Profile>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Iso2 { get; set; }
        public string Iso3 { get; set; }

        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<CustomerContact> CustomerContact { get; set; }
        public virtual ICollection<Profile> Profile { get; set; }
    }
}
