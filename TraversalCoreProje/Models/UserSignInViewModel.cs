using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı girin.")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Lütfen şifrenizi girin.")] 
        public string Password { get; set; }
    }
    
}