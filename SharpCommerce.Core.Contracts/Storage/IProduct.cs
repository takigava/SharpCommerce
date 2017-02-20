using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IProduct
    {
         int ProductId { get;  }
         string ArtNo { get;  }
         string Title { get;  }
         string ShortDescription { get;  }
         string Description { get;  }
         bool? Enabled { get;  }
         DateTime AddDate { get;  }
         DateTime ModifiedDate { get;  }
         bool? EnabledRatio { get;  }
         bool? ShowRatio { get;  }
         double? Ratio { get;  }
         double? Weight { get;  }
         string Size { get;  }
         string Slug { get;  }
         int? BadgeId { get;  }
         double? Discount { get;  }
         bool? IsFreeShipping { get;  }
         decimal? Price { get;  }
         int? RelatedProductId { get;  }
         int? Quantity { get;  }
    }
}
