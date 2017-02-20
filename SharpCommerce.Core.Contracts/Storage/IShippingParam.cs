using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IShippingParam
    {
         int ShippingParamId { get;  }
         int ShippingMethodId { get;  }
         string Name { get;  }
         string Value { get;  }
    }
}
