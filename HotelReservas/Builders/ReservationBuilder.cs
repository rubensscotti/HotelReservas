using HotelReservas.Models;
using HotelReservas.Components;

namespace HotelReservas.Builders
{
    public class ReservationBuilder
    {
        private readonly Reservation _reservation;

        public ReservationBuilder()
        {
            _reservation = new Reservation();
        }

        public ReservationBuilder SetCustomerName(string name)
        {
            _reservation.CustomerName = name;
            return this;
        }

        public ReservationBuilder SetAccommodation(AccommodationComponent accommodation)
        {
            _reservation.Accommodation = accommodation;
            return this;
        }

        public ReservationBuilder AddService(ServiceComponent service)
        {
            _reservation.Services.Add(service);
            return this;
        }

        public Reservation Build()
        {
            return _reservation;
        }
    }
}
