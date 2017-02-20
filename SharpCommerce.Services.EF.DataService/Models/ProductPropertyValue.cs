using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ProductPropertyValue
    {
        public int ProductPropertyId { get; set; }
        public int ProductId { get; set; }
        public int PropertyValueId { get; set; }
        public int? SortOrder { get; set; }

        public virtual Product Product { get; set; }
        public virtual PropertyValue PropertyValue { get; set; }
    }
}
