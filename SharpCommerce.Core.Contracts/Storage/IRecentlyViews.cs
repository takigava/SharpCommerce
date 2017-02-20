using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IRecentlyViews
    {
         int RecentlyViewsId { get;  }
         Guid CustomerId { get;  }
         int ProductId { get;  }
         DateTime ViewDate { get;  }
    }
}
