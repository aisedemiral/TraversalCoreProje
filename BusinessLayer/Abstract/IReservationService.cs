using EntityLayer.Concrete;

namespace BusinessLayer.Abstract;

public interface IReservationService:IGenericService<Reservation>
{
    List<Reservation> GetListWithReservationByPrevious(int id);

    List<Reservation> GetListWithReservationByAccepted(int id);
    List<Reservation> GetListWithReservationByWaitApproval(int id);
}