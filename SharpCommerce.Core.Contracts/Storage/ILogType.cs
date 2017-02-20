using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface ILogType
    {
         int TypeId { get;  }
         string Value { get;  }
    }
}
