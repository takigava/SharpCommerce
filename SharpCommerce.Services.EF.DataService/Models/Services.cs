using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Services
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Icon { get; set; }
    }
}
