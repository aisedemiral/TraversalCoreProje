using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers;

public class CommentController : Controller
{
   private CommentManager commentManager = new CommentManager(new EfCommentDal());

   [HttpGet]
   public PartialViewResult AddComment()
   {
      return PartialView();
   }
   [HttpPost]
   public IActionResult AddComment(Comment p)
   {
      p.CommentDate=Convert.ToDateTime(DateTime.Now.ToShortDateString());
      p.CommentState = true;
      p.DestinationID = 3;
      commentManager.TAdd(p);
      return RedirectToAction("Index","Destination");
   }
}