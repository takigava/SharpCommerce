using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SharpCommerce.Modules.Account.Models.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
