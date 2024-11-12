namespace HotelReservas.Components
{
    public class PackageComposite : PackageComponent
    {
        private readonly List<PackageComponent> _components = new();

        public PackageComposite(string name) : base(name, 0) { }

        public void Add(PackageComponent component)
        {
            _components.Add(component);
            Price += component.Price;
        }

        public void Remove(PackageComponent component)
        {
            _components.Remove(component);
            Price -= component.Price;
        }

        public override void Display()
        {
            Console.WriteLine($"Package: {Name} - ${Price}");
            foreach (var component in _components)
            {
                component.Display();
            }
        }
    }
}
