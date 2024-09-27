using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRule;

public class GuideValidator:AbstractValidator<Guide>
{
    public GuideValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen rehber adını giriniz!!");
        RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen rehber açıklamasınız giriniz giriniz!!");
        RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen rehber görselini giriniz giriniz!!");
        RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden kısa bir isim giriniz!");
        RuleFor(x => x.Name).MinimumLength(8).WithMessage("Lütfen 8 karakterden uzun bir isim giriniz");
    }
}