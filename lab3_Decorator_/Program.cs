using System;
using lab3_Decorator_.Beverages;
using lab3_Decorator_.CondimentDecorators;

namespace lab3_Decorator_
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage1 = new Soy(new Milk(new Mocha(new Whip(new HouseBlend()))));

            Beverage beverage2 = new Whip(new Soy(new Milk(new DarkRoast())));

            Beverage beverage3 = new Milk(new Whip(new Decaf()));

            Beverage beverage4 = new Mocha(new Expresso());

            Console.WriteLine($"\nОписание 1 напитка: {beverage1.GetDescription()}");
            Console.WriteLine($"Цена 1 напитка: {beverage1.Cost()}");

            Console.WriteLine($"\nОписание 2 напитка: {beverage2.GetDescription()}");
            Console.WriteLine($"Цена 2 напитка: {beverage2.Cost()}");

            Console.WriteLine($"\nОписание 3 напитка: {beverage3.GetDescription()}");
            Console.WriteLine($"Цена 3 напитка: {beverage3.Cost()}");

            Console.WriteLine($"\nОписание 4 напитка: {beverage4.GetDescription()}");
            Console.WriteLine($"Цена 4 напитка: {beverage4.Cost()}");

            Console.ReadKey();
        }
    }
}
