using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using TraversalCoreProje.Areas.Member.Models;

namespace TraversalCoreProje.Areas.Member.Controllers;
[Area("Member")]
[Route("Member/[controller]/[action]")]
public class ProfileController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public ProfileController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    { 
        var values = await _userManager.FindByNameAsync(User.Identity.Name);
        UserEditViewModel userEditViewModel = new UserEditViewModel();
        userEditViewModel.Name = values.Name;
        userEditViewModel.SurName = values.SurName;
        userEditViewModel.PhoneNumber = values.PhoneNumber;
        userEditViewModel.Mail = values.Email;
        return View(userEditViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> Index(UserEditViewModel p)
    {
        var user = await _userManager.FindByNameAsync(User.Identity.Name);
        if (p.Image !=null)
        {
            var resource = Directory.GetCurrentDirectory();
            var extention = Path.GetExtension(p.Image.FileName);
            var imagename = Guid.NewGuid() + extention;
            var savelocation = resource + "/wwwroot/userimages/" + imagename;
            var stream = new FileStream(savelocation, FileMode.Create);
            await p.Image.CopyToAsync(stream);
            user.ImageUrl = imagename;
        }

        user.Name = p.Name;
        user.SurName = p.SurName;
        user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
        var result = await _userManager.UpdateAsync(user);
        if (result.Succeeded)
        {
            return RedirectToAction("SingIn", "Login");
        }

        return View();
    }
}