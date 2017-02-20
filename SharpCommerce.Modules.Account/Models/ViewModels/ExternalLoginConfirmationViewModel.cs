using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SharpCommerce.Modules.Account.Models.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
