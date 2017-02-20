using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IMailFormat
    {
         int MailFormatId { get;  }
         string FormatName { get;  }
         string FormatText { get;  }
         int? FormatTypeId { get;  }
         int? SortOrder { get;  }
         bool? Enabled { get;  }
         DateTime AddDate { get;  }
         DateTime ModifiedDate { get;  }
    }
}
