namespace FactoryMethod
{
    public class PanelDeveloper : Developer
    {
        public PanelDeveloper(string name) : base(name)
        {
        }

        public override House CreateBuilding(string name)
        {
            return new PanelHouse(name);
        }
    }
}