using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface INewsCategory
    {
         int NewsCategoryId { get;  }
         string Name { get;  }
         int? SortOrder { get;  }
    }
}
