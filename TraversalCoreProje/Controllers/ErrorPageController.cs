using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers;

public class ErrorPageController : Controller
{
    // GET
    public IActionResult Error404(int code)
    {
        
        return View();
    }
}