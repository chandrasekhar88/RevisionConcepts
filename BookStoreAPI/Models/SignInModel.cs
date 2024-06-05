using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.Models
{
    public class SignInModel
    {
        [Required, EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}
