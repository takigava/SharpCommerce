using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface ICategory
    {
         int CategoryId { get;  }
         string Name { get;  }
         int? ParentCategoryId { get;  }
         string Description { get;  }
         string Picture { get;  }
         int? SortOrder { get;  }
         bool? Enabled { get;  }
         string WebUrl { get;  }
         bool? DisplayFilter { get;  }
         bool? DisplayChildProducts { get;  }
         bool? DisplayThematicTabs { get;  }
         string DisplayStyle { get;  }
    }
}
