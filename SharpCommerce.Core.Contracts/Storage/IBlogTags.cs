using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IBlogTags
    {
         int BlogTagsId { get;  }
         int BlogId { get;  }
         int TagId { get;  }
    }
}
