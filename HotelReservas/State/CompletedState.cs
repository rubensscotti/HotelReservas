using HotelReservas.Models;

namespace HotelReservas.State
{
    public class CompletedState : IReservationState
    {
        public void Handle(Reservation reservation)
        {
            Console.WriteLine("Reserva finalizada.");
        }
    }
}
