using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default;

public class _PopularDestinationsPartial:ViewComponent
{
    private DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
    public IViewComponentResult Invoke()
    {
        var values = destinationManager.TGetList();
        return View(values);
    }
}