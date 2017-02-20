using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ProductPhoto
    {
        public int ProductPhotoId { get; set; }
        public int ProductId { get; set; }
        public string WebUrl { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? IsMainPhoto { get; set; }

        public virtual Product Product { get; set; }
    }
}
