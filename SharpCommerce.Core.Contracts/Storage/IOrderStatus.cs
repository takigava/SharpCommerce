using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IOrderStatus
    {
         int OrderStatusId { get;  }
         string Name { get;  }
    }
}
