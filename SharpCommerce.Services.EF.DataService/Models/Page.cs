using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Page
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        public string PageText { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int? SortOrder { get; set; }
        public bool? Enabled { get; set; }
        public string Slug { get; set; }
        public bool? IsCommentEnabled { get; set; }
        public int? ParentId { get; set; }
    }
}
