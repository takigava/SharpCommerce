using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface INewsTags
    {
         int NewsTagsId { get;  }
         int NewsId { get;  }
         int TagId { get;  }
    }
}
