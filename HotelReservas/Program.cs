using System;
using HotelReservas.Models;
using HotelReservas.Components;
using HotelReservas.Builders;

namespace HotelReservas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de uma reserva usando o Builder
            var builder = new ReservationBuilder()
                .SetCustomerName("João Silva")
                .SetAccommodation(new AccommodationComponent("Suite Deluxe", 150))
                .AddService(new ServiceComponent("Café da Manhã", 20))
                .AddService(new ServiceComponent("Spa", 50));

            var reservation = builder.Build();

            // Exibe os detalhes da reserva
            reservation.Display();

            // Progride pelos estados
            reservation.Progress();
            reservation.Progress();
            reservation.Progress();
        }
    }
}
