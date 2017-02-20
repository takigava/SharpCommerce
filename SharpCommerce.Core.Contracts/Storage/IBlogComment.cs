using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IBlogComment
    {
         int BlogCommentId { get;  }
         int BlogId { get;  }
         int? ParentCommentId { get;  }
         bool? IsSpam { get;  }
         bool? IsApproved { get;  }
         string Comment { get;  }
         string WebSite { get;  }
         DateTime CommentDate { get;  }
         Guid? ModeratedBy { get;  }
         bool? IsDelated { get;  }
         string Email { get;  }
         string FullName { get;  }
         string FirstName { get;  }
         string LastName { get;  }
         Guid? CustomerId { get;  }
    }
}
