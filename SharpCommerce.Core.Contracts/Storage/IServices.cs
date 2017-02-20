using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IServices
    {
         int ServiceId { get;  }
         string Title { get;  }
         string Text { get;  }
         string Icon { get;  }
    }
}
