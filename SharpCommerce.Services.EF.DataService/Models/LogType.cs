using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class LogType
    {
        public LogType()
        {
            Log = new HashSet<Log>();
        }

        public int TypeId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Log> Log { get; set; }
    }
}
