using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IProductBadge
    {
         int BadgeId { get;  }
         string Value { get;  }
    }
}
