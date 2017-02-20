using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Faq
    {
        public int FaqId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
