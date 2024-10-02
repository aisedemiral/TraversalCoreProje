using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRule;

public class AnnouncementValidator:AbstractValidator<AnnouncementAddDTO>
{
    public AnnouncementValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Başlığı Boş Geçmeyin!!");
        RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen Duyuru İçeriğini Boş Geçmeyin!!");
        RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen başlığğınız 5 karakterden uzun olsun.");
        RuleFor(x => x.Content).MinimumLength(5).WithMessage("Lütfen Duyurunun içeriğini 5 karakterden fazla giriniz.");
        RuleFor(x => x.Title).MaximumLength(30).WithMessage("Lütfen başlığğınız 30 karakterden kısa olsun.");
        RuleFor(x => x.Content).MaximumLength(200).WithMessage("Lütfen başlığğınız 200 karakterden kısa olsun.");


    }
}