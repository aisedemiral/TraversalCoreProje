using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRule;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Container;

public static class Extension
{
    public static void ContainerDependencies(this IServiceCollection services)
    {
        services.AddScoped<ICommentService, CommentManager>();
        services.AddScoped<ICommentDal, EfCommentDal>();

        services.AddScoped<IDestinationService, DestinationManager>();
        services.AddScoped<IDestinationDal, EfDestinationDal>();

        services.AddScoped<IAppUserService, AppUSerManager>();
        services.AddScoped<IAppUserDal, EfAppUserDal>();
        
        services.AddScoped<IReservationService, ReservationManager>();
        services.AddScoped<IReservationDal, EfReservationDal>();

        services.AddScoped<IGuideService, GuideManager>();
        services.AddScoped<IGuideDal, EfGuideDal>();

        services.AddScoped<IExcelService, ExcelManager>();
        services.AddScoped<IPdfService, PdfManager>();
        
        services.AddScoped<IContactUsService, ContactUsManager>();
        services.AddScoped<IContactUsDal, EfContactUsDal>();

        services.AddScoped<IAnnouncementService, AnnouncementManager>();
        services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();


    }

    public static void CustomerValidator(this IServiceCollection services)
    {
        services.AddTransient<IValidator<AnnouncementAddDTO>, AnnouncementValidator>();

    }
}