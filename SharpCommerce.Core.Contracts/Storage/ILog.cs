using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface ILog
    {
         int LogId { get;  }
         string Message { get;  }
         DateTime Date { get;  }
         int? TypeId { get;  }
    }
}
