using System.ComponentModel.DataAnnotations;

namespace HXShopCoreApp.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
