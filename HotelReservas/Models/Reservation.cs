using HotelReservas.Components;
using HotelReservas.State;

namespace HotelReservas.Models
{
    public class Reservation
    {
        public string CustomerName { get; set; }
        public AccommodationComponent Accommodation { get; set; }
        public List<ServiceComponent> Services { get; } = new();
        public IReservationState State { get; set; } = new PendingState();

        public void Progress()
        {
            State.Handle(this);
        }

        public void Display()
        {
            Console.WriteLine($"Reservation for {CustomerName} - State: {State.GetType().Name}");
            Accommodation.Display();

            foreach (var service in Services)
            {
                service.Display();
            }
        }
    }
}
