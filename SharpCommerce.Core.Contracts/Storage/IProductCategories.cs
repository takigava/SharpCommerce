using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
     public interface IProductCategories
    {
         int ProductCategoriesId { get;  }
         int CategoryId { get;  }
         int ProductId { get;  }
         int? SortOrder { get;  }
         bool? IsMainCategory { get;  }
    }
}
