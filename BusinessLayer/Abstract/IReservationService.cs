using EntityLayer.Concrete;

namespace BusinessLayer.Abstract;

public interface IReservationService:IGenericService<Reservation>
{
    List<Reservation> GetListApprovalReservation(int id);
}