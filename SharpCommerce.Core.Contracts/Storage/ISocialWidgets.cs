using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface ISocialWidgets
    {
         int WidgetId { get;  }
         string Name { get;  }
         string ScriptText { get;  }
         bool? Enabled { get;  }
         int? SortOrder { get;  }
    }
}
