using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IMainPageProduct
    {
         int MainPageProductId { get;  }
         int ProductId { get;  }
         bool? IsActive { get;  }
         int? SortOrder { get;  }
    }
}
