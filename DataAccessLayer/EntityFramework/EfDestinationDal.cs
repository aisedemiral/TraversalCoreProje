using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfDestinationDal:GenericRepository<Destination>,IDestinationDal
{
    public List<Destination> GetDestinationWithGuide(int id)
    {
        throw new NotImplementedException();
    }

    public List<Destination> GetLast4Destinations()
    {
        using (var context=new Context())
        {
            var values = context.Destinations.Take(4).OrderByDescending(x => x.DestinationID).ToList();
            return values;
        }
    }
}