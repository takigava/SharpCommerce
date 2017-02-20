using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCommerce.Core.Contracts.Storage
{
    public interface IBlock
    {
        int BlockId { get; }
        string BlockKey { get; }
        string InnerName { get; }
        string BlockContent { get; }
        DateTime AddDate { get; }
        DateTime ModifiedDate { get; }
        bool? Enabled { get;  }
    }
}
