using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IOrderedCart
    {
         int OrderedCartId { get;  }
         int OrderId { get;  }
         int ProductId { get;  }
         string ProductName { get;  }
         decimal? Price { get;  }
         int? Quantity { get;  }
         string ArtNo { get;  }
         decimal? SupplyPrice { get;  }
         double? Weight { get;  }
    }
}
