using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IMainMenu
    {
         int MenuItemId { get;  }
         int? MenuItemParentId { get;  }
         string Name { get;  }
         string Icon { get;  }
         int? SortOrder { get;  }
         bool? Enabled { get;  }
         string WebUrl { get;  }
         bool? IsIconEnabled { get;  }
    }
}
