using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface ICurrency
    {
         int CurrencyId { get;  }
         string Name { get;  }
         string Code { get;  }
         double? CurrencyValue { get;  }
         string CurrencyIso { get;  }
         bool? IsMainCurrency { get;  }
    }
}
