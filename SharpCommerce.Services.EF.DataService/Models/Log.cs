using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Log
    {
        public int LogId { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int? TypeId { get; set; }

        public virtual LogType Type { get; set; }
    }
}
