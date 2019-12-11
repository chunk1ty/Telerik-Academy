using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    public static class Program
    {
        public static void Main()
        {
            //VictorianFurnitureFactory victorianFurnitureFactory = new VictorianFurnitureFactory();
            //FurnitureClient client = new FurnitureClient(victorianFurnitureFactory);

            ModernFurnitureFactory modernFurnitureFactory = new ModernFurnitureFactory();
            FurnitureClient client = new FurnitureClient(modernFurnitureFactory);

            var table = client.CreteCoffeeTable();
            Console.WriteLine(table.Name);

            var chair = client.CreateChair();
            Console.WriteLine(chair.Legs);

            var sofa = client.CreateSofa();
            sofa.SitOn();
        }
    }
}

