using HotelReservas.Models;

namespace HotelReservas.State
{
    public interface IReservationState
    {
        void Handle(Reservation reservation);
    }
}
