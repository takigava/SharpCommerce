using System;
using System.Linq;
using System.Threading.Tasks;

namespace SharpCommerce.Core.Contracts.Entity
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
