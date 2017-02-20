using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Testimonials
    {
        public int TestimonialsId { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public string WebSite { get; set; }
    }
}
