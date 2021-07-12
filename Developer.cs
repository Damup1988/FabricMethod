namespace FactoryMethod
{
    public abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string name)
        {
            name = Name;
        }

        abstract public House CreateBuilding(string name);
    }
}