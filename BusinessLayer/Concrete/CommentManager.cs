using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Migrations;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class CommentManager:ICommentService
{
     ICommentDal commentDal;

     public CommentManager(ICommentDal commentDal)
     {
         this.commentDal = commentDal;
     }

     public void TAdd(Comment t)
    {
        commentDal.Insert(t);
    }

    public void TDelete(Comment t)
    {
        commentDal.Delete(t);
    }

    public void TUpdate(Comment t)
    {
        throw new NotImplementedException();
    }
    

    public List<Comment> TGetList()
    {
        return commentDal.GetList();

    }

    public Comment TGetByID(int id)
    {
        return commentDal.GetByID(id);
    }

    public List<Comment> TGetDestinationByID(int id)
    {
        return commentDal.GetListByFilter(x => x.DestinationID == id);
    }

    public List<Comment> TGetListCommentWithDestination()
    {
        return commentDal.GetListCommentWithDestination();
    }
}