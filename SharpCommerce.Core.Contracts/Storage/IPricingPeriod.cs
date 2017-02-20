using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IPricingPeriod
    {
         int PricingPeriodId { get;  }
         string Value { get;  }
    }
}
