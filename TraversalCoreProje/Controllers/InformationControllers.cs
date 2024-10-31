using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Member.Controllers;

public class InformationController : Controller
{
    // GET
    public IActionResult Index()
    {
        
        return View();
    }
}