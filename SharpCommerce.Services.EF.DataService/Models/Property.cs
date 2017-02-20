using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Property
    {
        public Property()
        {
            PropertyValue = new HashSet<PropertyValue>();
        }

        public int PropertyId { get; set; }
        public string Name { get; set; }
        public bool? UseInFilter { get; set; }
        public int? SortOrder { get; set; }

        public virtual ICollection<PropertyValue> PropertyValue { get; set; }
    }
}
