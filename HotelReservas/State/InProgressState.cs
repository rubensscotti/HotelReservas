using HotelReservas.Models;

namespace HotelReservas.State
{
    public class InProgressState : IReservationState
    {
        public void Handle(Reservation reservation)
        {
            Console.WriteLine("Reserva em andamento.");
            reservation.State = new ConfirmedState();            
        }
    }
}
