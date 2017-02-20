using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Profile
    {
        public int ProfileId { get; set; }
        public int? CityId { get; set; }
        public int? CountryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid UserId { get; set; }
        public string Avatar { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
    }
}
