using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class News
    {
        public News()
        {
            NewsComment = new HashSet<NewsComment>();
            NewsTags = new HashSet<NewsTags>();
        }

        public int NewsId { get; set; }
        public int NewsCategoryId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PublishDate { get; set; }
        public string Picture { get; set; }
        public bool? IsCommentEnabled { get; set; }
        public string Slug { get; set; }

        public virtual ICollection<NewsComment> NewsComment { get; set; }
        public virtual ICollection<NewsTags> NewsTags { get; set; }
        public virtual NewsCategory NewsCategory { get; set; }
    }
}
