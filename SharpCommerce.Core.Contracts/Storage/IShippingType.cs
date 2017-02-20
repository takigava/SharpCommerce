using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IShippingType
    {
         int ShippingTypeId { get;  }
         string Name { get;  }
    }
}
