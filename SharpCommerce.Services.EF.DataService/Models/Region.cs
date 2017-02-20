using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Region
    {
        public Region()
        {
            City = new HashSet<City>();
            CustomerContact = new HashSet<CustomerContact>();
        }

        public int RegionId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<CustomerContact> CustomerContact { get; set; }
    }
}
