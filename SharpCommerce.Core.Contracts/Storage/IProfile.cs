using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IProfile
    {
         int ProfileId { get;  }
         int? CityId { get;  }
         int? CountryId { get;  }
         string FirstName { get;  }
         string LastName { get;  }
         string SurName { get;  }
         DateTime DateOfBirth { get;  }
         Guid UserId { get;  }
         string Avatar { get;  }
    }
}
