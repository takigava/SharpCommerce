using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IProductPhoto
    {
         int ProductPhotoId { get;  }
         int ProductId { get;  }
         string WebUrl { get;  }
         string Description { get;  }
         int? SortOrder { get;  }
         DateTime AddDate { get;  }
         DateTime ModifiedDate { get;  }
         bool? IsMainPhoto { get;  }
    }
}
