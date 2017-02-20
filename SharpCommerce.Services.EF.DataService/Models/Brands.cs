using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Brands
    {
        public int BrandId { get; set; }
        public string WebSiteUrl { get; set; }
        public string Picture { get; set; }
        public string Title { get; set; }
    }
}
