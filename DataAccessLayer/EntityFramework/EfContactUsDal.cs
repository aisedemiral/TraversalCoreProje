using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfContactUsDal:GenericRepository<ContactUs>,IContactUsDal
{
    public List<ContactUs> GetListContactUsByTrue()
    {
        using (var context = new Context())
        {
            var values = context.ContactUses.Where(x => x.MessageStatus == true).ToList();
            return values;
        }    }

    public List<ContactUs> GetListContactUsByFalse()
    {
        using (var context=new Context())
        {
            var values = context.ContactUses.Where(x => x.MessageStatus == false).ToList();
            return values;
        }
    }

    public void ContactUsStatusChangeToFalse(int id)
    {
       
    }
}