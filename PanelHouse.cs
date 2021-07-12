namespace FactoryMethod
{
    internal class PanelHouse : House
    {
        public PanelHouse(string name) : base(name)
        {
            System.Console.WriteLine("A panel house has been built");
        }
    }
}