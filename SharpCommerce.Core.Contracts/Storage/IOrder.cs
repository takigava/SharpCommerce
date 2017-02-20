using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IOrder
    {
         int OrderId { get;  }
         int ShippingMethodId { get;  }
         int PaymentMethodId { get;  }
         double? OrderDiscount { get;  }
         DateTime OrderDate { get;  }
         DateTime? PaymentDate { get;  }
         string CustomerComment { get;  }
         string StatusComment { get;  }
         string AdminComment { get;  }
         decimal? ShippingCost { get;  }
         decimal? TaxCost { get;  }
         decimal? SupplyTotal { get;  }
         decimal Sum { get;  }
         int OrderStatusId { get;  }
         int ShippingContactId { get;  }
         string PaymentMethodName { get;  }
         string ShippingMethodName { get;  }
         int OrderContactId { get;  }
         Guid? CustomerId { get;  }
    }
}
