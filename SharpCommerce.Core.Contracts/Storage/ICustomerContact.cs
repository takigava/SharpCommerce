using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface ICustomerContact
    {
         int ContactId { get;  }
         Guid? CustomerId { get;  }
         string Name { get;  }
         int? CountryId { get;  }
         int? RegionId { get;  }
         string City { get;  }
         int? CityId { get;  }
         string Address { get;  }
         string Telephone { get;  }
         string Fax { get;  }
         string Email { get;  }
         string Zip { get;  }
         bool? Main { get;  }
    }
}
