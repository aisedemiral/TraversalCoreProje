using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class SubAboutManager:ISubAboutService
{
     ISubAboutDal _subAboutDal;

     public SubAboutManager(ISubAboutDal subAboutDal)
     {
          _subAboutDal = subAboutDal;
     }

     public void TAdd(SubAbout t)
     {
          throw new NotImplementedException();
     }

     public void TDelete(SubAbout t)
     {
          throw new NotImplementedException();
     }

     public void TUpdate(SubAbout t)
     {
          throw new NotImplementedException();
     }

     public List<SubAbout> TGetList()
     {
          return _subAboutDal.GetList();
     }

     public SubAbout TGetByID(int id)
     {
          throw new NotImplementedException();
     }
}