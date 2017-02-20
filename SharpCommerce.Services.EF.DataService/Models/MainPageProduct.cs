using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class MainPageProduct
    {
        public int MainPageProductId { get; set; }
        public int ProductId { get; set; }
        public bool? IsActive { get; set; }
        public int? SortOrder { get; set; }

        public virtual Product Product { get; set; }
    }
}
