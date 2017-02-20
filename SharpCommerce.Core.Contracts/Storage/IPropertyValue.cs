using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IPropertyValue
    {
         int PropertyValueId { get;  }
         int PropertyId { get;  }
         string Value { get;  }
         bool? UseInFilter { get;  }
         int? SortOrder { get;  }
    }
}
