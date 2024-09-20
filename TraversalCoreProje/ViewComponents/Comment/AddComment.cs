using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Comment;

public class AddComment:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}