using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IBrands
    {
         int BrandId { get;  }
         string WebSiteUrl { get;  }
         string Picture { get;  }
         string Title { get;  }
    }
}
