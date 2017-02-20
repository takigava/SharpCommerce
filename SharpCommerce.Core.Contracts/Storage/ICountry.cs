using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface ICountry
    {
         int CountryId { get;  }
         string Name { get;  }
         string Iso2 { get;  }
         string Iso3 { get;  }
    }
}
