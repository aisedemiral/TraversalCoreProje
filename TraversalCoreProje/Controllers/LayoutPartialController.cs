using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers;

public class LayoutPartialController : Controller
{
    // GET
    public PartialViewResult Index()
    {
        return PartialView();
    }
}