using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface ITestimonials
    {
         int TestimonialsId { get;  }
         string Text { get;  }
         string Author { get;  }
         string WebSite { get;  }
    }
}
