using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default;

public class _FeaturePartial:ViewComponent
{
    private FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
    public IViewComponentResult Invoke()
    {
      //  var values = featureManager.TGetList();
       // ViewBag.image1=featureManager.TGetList().
        return View();
    }
}