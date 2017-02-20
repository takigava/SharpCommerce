using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface ITax
    {
         int TaxId { get;  }
         string Name { get;  }
         decimal? Value { get;  }
         bool? Enabled { get;  }
    }
}
