namespace HotelReservas.Components
{
    public abstract class PackageComponent
    {
        public string Name { get; }
        public double Price { get; protected set; }

        protected PackageComponent(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void Display();
    }
}
