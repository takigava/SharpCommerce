using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IPaymentParam
    {
         int PaymentParamId { get;  }
         int PaymentMethodId { get;  }
         string Name { get;  }
         string Value { get;  }
    }
}
