namespace FactoryMethod
{
    public abstract class House
    {
        public string Name { get; set; }

        public House(string name)
        {
            Name = name;
        }
    }
}