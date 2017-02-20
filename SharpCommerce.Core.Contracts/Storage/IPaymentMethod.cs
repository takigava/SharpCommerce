using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
     public interface IPaymentMethod
    {
         int PaymentMethodId { get;  }
         string Name { get;  }
         string Description { get;  }
         bool? Enabled { get;  }
         int? SortOrder { get;  }
         int? PaymentTypeId { get;  }
    }
}
