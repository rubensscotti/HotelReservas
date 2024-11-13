using HotelReservas.Components;

namespace HotelReservas.Components
{
    public class AccommodationComponent : PackageComponent
    {
        public AccommodationComponent(string name, double price) : base(name, price) { }

        public override void Display()
        {
            Console.WriteLine($"{Name} - ${Price}");
        }
    }
}
