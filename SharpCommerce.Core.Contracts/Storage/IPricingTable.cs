using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IPricingTable
    {
         int PricingTableId { get;  }
         string Name { get;  }
         decimal? Price { get;  }
         int? PricingPeriodId { get;  }
         int CurrencyId { get;  }
    }
}
