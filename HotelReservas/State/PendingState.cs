using HotelReservas.Models;

namespace HotelReservas.State
{
    public class PendingState : IReservationState
    {
        public void Handle(Reservation reservation)
        {
            Console.WriteLine("Reserva confirmada.");
            reservation.State = new ConfirmedState();
        }
    }
}
