using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class MainMenu
    {
        public int MenuItemId { get; set; }
        public int? MenuItemParentId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int? SortOrder { get; set; }
        public bool? Enabled { get; set; }
        public string WebUrl { get; set; }
        public bool? IsIconEnabled { get; set; }
    }
}
