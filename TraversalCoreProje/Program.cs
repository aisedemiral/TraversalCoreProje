using System.Net;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Container;
using BusinessLayer.ValidationRule;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Internal;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Localization;
using TraversalCoreProje.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProje.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<GetAllDestinationQueriesHandler>();
builder.Services.AddScoped<GetDestinationByIdQueryHandler>();
builder.Services.AddScoped<CreateDestinationCommandHandler>();
builder.Services.AddScoped<RemoveDestinationCommandHandler>();

builder.Services.AddMediatR(typeof(Program).Assembly);

builder.Services.AddLogging(x =>
{
    x.ClearProviders();
    x.SetMinimumLevel(LogLevel.Debug);
    x.AddDebug();
});
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>().AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).AddEntityFrameworkStores<Context>();

builder.Services.AddHttpClient();

builder.Services.ContainerDependencies();

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.CustomerValidator();


builder.Services.AddControllersWithViews().AddFluentValidation();


builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddLocalization(opt =>
{
    opt.ResourcesPath = "Resources";
});
builder.Services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login/SignIn/";
});
var app = builder.Build();


var path = Path.Combine(Directory.GetCurrentDirectory(), "Logs");
if (!Directory.Exists(path))
{
    Directory.CreateDirectory(path); // Klasörü oluştur
}

var loggerFactory = new LoggerFactory();
var logFilePath = Path.Combine(path, "log1.txt");
loggerFactory.AddFile(logFilePath); // Kendi dosya logger'ınızı ekleyin

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404","?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();
var suppertedCultures = new[] {"en","fr","es","gr","tr","de"};
var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(suppertedCultures[4])
    .AddSupportedUICultures(suppertedCultures).AddSupportedUICultures(suppertedCultures);
app.UseRequestLocalization(localizationOptions);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

    app.MapControllerRoute(
        name : "areas",
        pattern : "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.Run();