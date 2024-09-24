using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard;

public class _GuideList:ViewComponent
{
    private GuideManager guidemanager = new GuideManager(new EfGuideDal());
    public IViewComponentResult Invoke()
    {
        var values = guidemanager.TGetList();
        return View(values);
    }
}