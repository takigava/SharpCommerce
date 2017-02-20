using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IProductTax
    {
         int ProductTaxId { get;  }
         int ProductId { get;  }
         int? TaxId { get;  }
    }
}
