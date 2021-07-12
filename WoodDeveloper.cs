namespace FactoryMethod
{
    public class WoodDeveloper : Developer
    {
        public WoodDeveloper(string name) : base(name)
        {
        }

        public override House CreateBuilding(string name)
        {
            return new WoodHouse(name);
        }
    }
}