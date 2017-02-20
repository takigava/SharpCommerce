using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IProductDiscussion
    {
         int ProductDiscussionId { get;  }
         int ProductId { get;  }
         Guid Author { get;  }
         string Title { get;  }
         string Text { get;  }
         DateTime AddDate { get;  }
         Guid? ModeratedBy { get;  }
         bool? Moderated { get;  }
    }
}
