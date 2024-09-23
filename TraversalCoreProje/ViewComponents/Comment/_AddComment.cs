using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Comment;

public class _AddComment:ViewComponent
{ 
    CommentManager commentManager = new CommentManager(new EfCommentDal());
    public IViewComponentResult Invoke(EntityLayer.Concrete.Comment p = null)
    {
        if (p != null)
        {
            // HttpPost işlemi
            p.CommentDate = DateTime.Now;
            p.CommentState = true;
            commentManager.TAdd(p);
        }
            
        // Görünüm döndürme
        return View();
    }
}