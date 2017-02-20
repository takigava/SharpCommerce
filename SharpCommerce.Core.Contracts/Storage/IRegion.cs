using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IRegion
    {
         int RegionId { get;  }
         int CountryId { get;  }
         string Name { get;  }
         string Code { get;  }
    }
}
