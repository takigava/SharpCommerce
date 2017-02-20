using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface INews
    {
         int NewsId { get;  }
         int NewsCategoryId { get;  }
         string Title { get;  }
         string Text { get;  }
         DateTime PublishDate { get;  }
         string Picture { get;  }
         bool? IsCommentEnabled { get;  }
         string Slug { get;  }
    }
}
