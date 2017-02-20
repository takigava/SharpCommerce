using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Block
    {
        public int BlockId { get; set; }
        public string BlockKey { get; set; }
        public string InnerName { get; set; }
        public string BlockContent { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? Enabled { get; set; }
    }
}
