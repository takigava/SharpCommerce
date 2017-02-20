using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class NewsComment
    {
        public int NewsCommentId { get; set; }
        public int NewsId { get; set; }
        public int? ParentCommentId { get; set; }
        public bool? IsSpam { get; set; }
        public bool? IsApproved { get; set; }
        public string Comment { get; set; }
        public string WebSite { get; set; }
        public DateTime CommentDate { get; set; }
        public Guid? ModeratedBy { get; set; }
        public bool? IsDelated { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid? CustomerId { get; set; }

        public virtual News News { get; set; }
    }
}
