using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default;

public class _TestimonialPartial:ViewComponent
{
    private TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
    public IViewComponentResult Invoke()
    {
        var values = testimonialManager.TGetList();
        return View(values);
    }
}