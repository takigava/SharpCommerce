using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class RecentlyViews
    {
        public int RecentlyViewsId { get; set; }
        public Guid CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime ViewDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
