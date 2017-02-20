using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class SocialWidgets
    {
        public int WidgetId { get; set; }
        public string Name { get; set; }
        public string ScriptText { get; set; }
        public bool? Enabled { get; set; }
        public int? SortOrder { get; set; }
    }
}
