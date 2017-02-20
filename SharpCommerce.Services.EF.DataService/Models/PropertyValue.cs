using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class PropertyValue
    {
        public PropertyValue()
        {
            ProductPropertyValue = new HashSet<ProductPropertyValue>();
        }

        public int PropertyValueId { get; set; }
        public int PropertyId { get; set; }
        public string Value { get; set; }
        public bool? UseInFilter { get; set; }
        public int? SortOrder { get; set; }

        public virtual ICollection<ProductPropertyValue> ProductPropertyValue { get; set; }
        public virtual Property Property { get; set; }
    }
}
