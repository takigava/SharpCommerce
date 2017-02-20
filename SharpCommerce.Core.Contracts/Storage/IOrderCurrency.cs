using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IOrderCurrency
    {
         int OrderCurrencyId { get;  }
         int OrderId { get;  }
         string CurrencyCode { get;  }
         double? CurrencyValue { get;  }
    }
}
