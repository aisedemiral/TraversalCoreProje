using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace TraversalCoreProje.ViewComponents.MemberLayout;

public class _MemberLayoutHead:ViewComponent
{
    public ViewViewComponentResult Invoke()
    {
        return View();
    }  
}