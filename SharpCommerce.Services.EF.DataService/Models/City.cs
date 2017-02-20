using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class City
    {
        public City()
        {
            CustomerContact = new HashSet<CustomerContact>();
            Profile = new HashSet<Profile>();
        }

        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int RegionId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CustomerContact> CustomerContact { get; set; }
        public virtual ICollection<Profile> Profile { get; set; }
        public virtual Country Country { get; set; }
        public virtual Region Region { get; set; }
    }
}
