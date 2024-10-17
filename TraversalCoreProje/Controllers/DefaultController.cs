using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers;
[AllowAnonymous]
public class DefaultController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}