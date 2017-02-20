using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class MailFormat
    {
        public int MailFormatId { get; set; }
        public string FormatName { get; set; }
        public string FormatText { get; set; }
        public int? FormatTypeId { get; set; }
        public int? SortOrder { get; set; }
        public bool? Enabled { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual MailFormatType FormatType { get; set; }
    }
}
