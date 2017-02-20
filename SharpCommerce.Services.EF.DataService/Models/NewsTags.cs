using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class NewsTags
    {
        public int NewsTagsId { get; set; }
        public int NewsId { get; set; }
        public int TagId { get; set; }

        public virtual News News { get; set; }
        public virtual Tags Tag { get; set; }
    }
}
