using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IPage
    {
         int PageId { get;  }
         string PageName { get;  }
         string PageText { get;  }
         DateTime AddDate { get;  }
         DateTime ModifiedDate { get;  }
         int? SortOrder { get;  }
         bool? Enabled { get;  }
         string Slug { get;  }
         bool? IsCommentEnabled { get;  }
         int? ParentId { get;  }
    }
}
