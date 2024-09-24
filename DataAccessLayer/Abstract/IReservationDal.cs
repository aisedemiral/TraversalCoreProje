using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract;

public interface IReservationDal:IGenericDal<Reservation>
{
   List<Reservation> GetListWithReservationsByWaitApproval(int id);
   List<Reservation> GetListWithReservationByAccepted(int id);
   List<Reservation> GetListWithReservationByPrevious(int id);

}