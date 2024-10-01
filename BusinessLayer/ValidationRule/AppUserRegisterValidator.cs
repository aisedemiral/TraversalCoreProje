using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRule;

public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDTO>
{
    public AppUserRegisterValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanını boş geçmeyiniz!!");
        RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyad alanını boş geçmeyiniz!!");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanını boş geçmeyiniz!!");
        RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı alanını boş geçmeyiniz!!");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanını boş geçmeyiniz!!");
        RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Yukarıda yazdığınız şifreyi tekrar yazınız!!");
        RuleFor(x => x.UserName).MinimumLength(5).WithMessage("Lütfen kullanıcı adınızı 5 karakterden fazla giriniz");
        RuleFor(x => x.UserName).MaximumLength(20).WithMessage("Lütfen kullanıcı adınızı 20 karakterden az giriniz");
        RuleFor(x => x.Password).Equal(y => y.ConfirmPassword)
            .WithMessage("Şifreleriniz birbiri ile uyuşmuyor lütfen tekrar deneyin."); 

    }
}