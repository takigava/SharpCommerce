using System;
using System.Linq;
using System.Threading.Tasks;

namespace SharpCommerce.Core.Contracts.Entity
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
