using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IRelatedProduct
    {
         int RelatedProductId { get;  }
         int MainProductId { get;  }
         int ChildProductId { get;  }
    }
}
