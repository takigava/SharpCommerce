using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ProductDiscussion
    {
        public int ProductDiscussionId { get; set; }
        public int ProductId { get; set; }
        public Guid Author { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime AddDate { get; set; }
        public Guid? ModeratedBy { get; set; }
        public bool? Moderated { get; set; }

        public virtual Product Product { get; set; }
    }
}
