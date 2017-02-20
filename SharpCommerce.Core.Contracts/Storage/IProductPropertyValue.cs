using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IProductPropertyValue
    {
         int ProductPropertyId { get;  }
         int ProductId { get;  }
         int PropertyValueId { get;  }
         int? SortOrder { get;  }
    }
}
