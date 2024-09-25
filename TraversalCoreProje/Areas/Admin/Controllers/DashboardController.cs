using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers;
[Area("Admin")]

public class DashboardController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}