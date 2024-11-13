namespace HotelReservas.Components
{
    public class ServiceComponent : PackageComponent
    {
        public ServiceComponent(string name, double price) : base(name, price) { }

        public override void Display()
        {
            Console.WriteLine($"{Name} - ${Price}");
        }
    }
}
