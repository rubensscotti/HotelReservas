using HotelReservas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservas.State
{
    public interface IReservationState
    {
        void Handle(Reservation reservation);
    }
}
