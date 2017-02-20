using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IOrderContact
    {
         int OrderContactId { get;  }
         string FullName { get;  }
         string FirstName { get;  }
         string LastName { get;  }
         string City { get;  }
         string Telephone { get;  }
         string Fax { get;  }
         string Email { get;  }
         string Zip { get;  }
         string Address { get;  }
         string Country { get;  }
    }
}
