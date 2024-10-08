using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfGuideDal:GenericRepository<Guide>,IGuideDal
{
    Context context = new Context();

    public void ChangeToTrueByGuide(int id)
    {
        var values = context.Guides.Find(id);
        values.Status = false;
        context.Update(values);
        context.SaveChanges();
    }

    public void ChangeToFalseByGuide(int id)
    {
        var values = context.Guides.Find(id);
        values.Status = true;
        context.Update(values);
        context.SaveChanges(); 
    }
}