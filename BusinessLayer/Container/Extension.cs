using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
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

    }
}