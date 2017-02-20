using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IProperty
    {
         int PropertyId { get;  }
         string Name { get;  }
         bool? UseInFilter { get;  }
         int? SortOrder { get;  }
    }
}
