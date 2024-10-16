using DataAccessLayer.Concrete;

namespace DataAccessLayer.UnitOfWork;

public class UnitOfWorkDal:IUnitOfWorkDal
{
    private readonly Context _context;
    private IUnitOfWorkDal _unitOfWorkDalImplementation;

    public UnitOfWorkDal(Context context)
    {
        _context = context;
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}