using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IPaymentType
    {
         int PaymentTypeId { get;  }
         string Name { get;  }
    }
}
