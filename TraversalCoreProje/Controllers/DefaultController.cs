using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers;

public class DefaultController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}