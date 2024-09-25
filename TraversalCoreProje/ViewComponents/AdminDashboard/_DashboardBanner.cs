using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.AdminDashboard;

public class _DashboardBanner:ViewComponent
{
    public IViewComponentResult Invoke(int id)
    {
        return View();
    }
}