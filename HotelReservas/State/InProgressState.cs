using HotelReservas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservas.State
{
    public class InProgressState : IReservationState
    {
        public void Handle(Reservation reservation)
        {
            Console.WriteLine("Reserva completa.");
            reservation.State = new CompletedState();
        }
    }
}
