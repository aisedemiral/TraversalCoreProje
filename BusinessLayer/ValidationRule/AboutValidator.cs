using System.Data;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRule;

public class AboutValidator:AbstractValidator<About>
{
    public AboutValidator()
    {
        RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz!!!");
        RuleFor(x => x.Description).MinimumLength(10)
            .WithMessage("Lütfen en az on karakterlik bir açıklama yazısı giriniz.");
        RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Lütfen açıklamayı kısaltınız.");

    }
}