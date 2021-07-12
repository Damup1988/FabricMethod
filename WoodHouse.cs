namespace FactoryMethod
{
    internal class WoodHouse : House
    {
        public WoodHouse(string name) : base(name)
        {
            System.Console.WriteLine("A wood house has been built");
        }
    }
}