using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Factories;
using DecoratorPattern.Types;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeStore store = new StarbucksStore();

            Beverage espresso = store.OrderCoffee(CoffeeType.Espresso);
            PrintBeverage(espresso);

            Beverage cappuccino = store.OrderCoffee(CoffeeType.Cappuccino);
            PrintBeverage(cappuccino);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.cost().ToString("#.##"));
        }
    }
}