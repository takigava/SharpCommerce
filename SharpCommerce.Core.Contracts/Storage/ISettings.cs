using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface ISettings
    {
         int SettindId { get;  }
         string Name { get;  }
         string Value { get;  }
    }
}
