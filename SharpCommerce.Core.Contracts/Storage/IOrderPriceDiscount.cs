using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IOrderPriceDiscount
    {
         int OrderPriceDiscountId { get;  }
         decimal? PriceStartRange { get;  }
         decimal? PriceEndRange { get;  }
         double? PriceDiscount { get;  }
    }
}
