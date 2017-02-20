using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IMailFormatType
    {
         int MailFormatTypeId { get;  }
         string TypeName { get;  }
         int? SortOrder { get;  }
         string Comment { get;  }
    }
}
