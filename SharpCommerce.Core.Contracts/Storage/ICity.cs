using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface ICity
    {
         int CityId { get;  }
         int CountryId { get;  }
         int RegionId { get;  }
         string Name { get;  }
    }
}
