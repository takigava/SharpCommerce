using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IFaq
    {
         int FaqId { get;  }
         string Title { get;  }
         string Text { get;  }
    }
}
