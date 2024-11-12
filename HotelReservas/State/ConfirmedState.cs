using HotelReservas.Models;

namespace HotelReservas.State
{
    public class ConfirmedState : IReservationState
    {
        public void Handle(Reservation reservation)
        {
            Console.WriteLine("Reserva confirmada.");
            reservation.State = new CompletedState();
        }
    }
}
