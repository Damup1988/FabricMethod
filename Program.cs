using System;

namespace FactoryMethod
{
    class Program
    {
        static void SellHouse(House house)
        {
            System.Console.WriteLine($"{house.Name} has been sold");
        }
        static void Main(string[] args)
        {
            Developer d = new WoodDeveloper("UnistroyWood");
            House h = d.CreateBuilding("Moscow wood building has been sold");
            d = new PanelDeveloper("UnistroyPanel");
            House h2 = d.CreateBuilding("NY panel building has been sold");

            SellHouse(h);
            SellHouse(h2);
        }
    }
}
