using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
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
        throw new NotImplementedException();
    }

    public void TUpdate(Comment t)
    {
        throw new NotImplementedException();
    }

    public List<Comment> TGetList()
    {
        throw new NotImplementedException();
    }

    public Comment TGetByID(int id)
    {
        throw new NotImplementedException();
    }

    public List<Comment> TGetDestinationByID(int id)
    {
        return commentDal.GetListByFilter(x => x.DestinationID == id);
    }
}