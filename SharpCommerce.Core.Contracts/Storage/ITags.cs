using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface ITags
    {
         int TagId { get;  }
         string Tag { get;  }
    }
}
