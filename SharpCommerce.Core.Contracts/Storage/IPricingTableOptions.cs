using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IPricingTableOptions
    {
         int PricingTableOptionId { get;  }
         int PricingTableId { get;  }
         string Name { get;  }
         string Value { get;  }
    }
}
