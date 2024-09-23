using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models;

public class UserRegisterViewModel
{
    [Required(ErrorMessage = "Lütfen Adınızı Giriniz!!")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz!!")]
    public string SurName { get; set; } 
    [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz!!")]
    public string UserName { get; set; }
    [Required(ErrorMessage = "Lütfen Mail Adresini Giriniz!!")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Lütfen Şirfenizi Giriniz!!")]
    public string Password { get; set; }
    [Required(ErrorMessage = "Lütfen Şireyi Tekrar Giriniz!!")]
    [Compare("Password", ErrorMessage = "Şifreler Uyumlu Değildir!!")]
    public string ConfirmPassword { get; set; }
    
}