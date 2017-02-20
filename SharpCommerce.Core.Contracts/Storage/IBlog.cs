using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IBlog
    {
         int BlogId { get;  }
         int BlogCategoryId { get;  }
         string Title { get;  }
         string Text { get;  }
         DateTime PublishDate { get;  }
         string Picture { get;  }
         bool? IsCommentEnabled { get;  }
         string Slug { get;  }
    }
}
