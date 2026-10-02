using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Factories
{
    internal class StarbucksStore : CoffeeStore
    {
        protected override Beverage CreateCoffee(CoffeeType type)
        {
            Beverage beverage;

            switch (type)
            {
                case CoffeeType.Espresso:
                    return new Espresso();

                case CoffeeType.Doppio:
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    return beverage;

                case CoffeeType.Lungo:
                    beverage = new Espresso();
                    beverage = new Water(beverage);
                    return beverage;

                case CoffeeType.Macchiato:
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    return beverage;

                case CoffeeType.Corretto:
                    beverage = new Espresso();
                    beverage = new Liqour(beverage);
                    return beverage;

                case CoffeeType.ConPanna:
                    beverage = new Espresso();
                    beverage = new Whip(beverage);
                    return beverage;

                case CoffeeType.Cappuccino:
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    return beverage;

                case CoffeeType.Americano:
                    beverage = new Espresso();
                    beverage = new Water(beverage);
                    beverage = new Water(beverage);
                    return beverage;

                case CoffeeType.CaffeLatte:
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    return beverage;

                case CoffeeType.FlatWhite:
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    return beverage;

                case CoffeeType.Romana:
                    beverage = new Espresso();
                    beverage = new Lemon(beverage);
                    return beverage;

                case CoffeeType.Morocchino:
                    beverage = new Espresso();
                    beverage = new Chocolate(beverage);
                    beverage = new MilkFoam(beverage);
                    return beverage;

                case CoffeeType.Mocha:
                    beverage = new Espresso();
                    beverage = new Chocolate(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    return beverage;

                case CoffeeType.Bicerin:
                    beverage = new Espresso();
                    beverage = new BlackChocolate(beverage);
                    beverage = new WhiteChocolate(beverage);
                    beverage = new Whip(beverage);
                    return beverage;

                case CoffeeType.Breve:
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    beverage = new HalfMilk(beverage);
                    return beverage;

                case CoffeeType.RafCoffee:
                    beverage = new Espresso();
                    beverage = new VanillaSugar(beverage);
                    beverage = new Cream(beverage);
                    return beverage;

                case CoffeeType.MeadRaf:
                    beverage = new Espresso();
                    beverage = new Honey(beverage);
                    beverage = new Cream(beverage);
                    return beverage;

                case CoffeeType.Galao:
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    beverage = new MilkFoam(beverage);
                    return beverage;

                case CoffeeType.CaffeAffogato:
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new IceCream(beverage);
                    return beverage;

                case CoffeeType.ViennaCoffee:
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Whip(beverage);
                    beverage = new Whip(beverage);
                    return beverage;

                case CoffeeType.Glace:
                    beverage = new Espresso();
                    beverage = new IceCream(beverage);
                    return beverage;

                case CoffeeType.ChocolateMilk:
                    beverage = new Chocolate();
                    beverage = new Milk(beverage);
                    return beverage;

                case CoffeeType.DemiCreme:
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Cream(beverage);
                    return beverage;

                case CoffeeType.LatteMacchiato:
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    return beverage;

                case CoffeeType.Freddo:
                    beverage = new Espresso();
                    beverage = new Liqour(beverage);
                    beverage = new Ice(beverage);
                    return beverage;

                case CoffeeType.Frappuccino:
                    beverage = new Espresso();
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    return beverage;

                case CoffeeType.CaramelFrappuccino:
                    beverage = new Espresso();
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Syrup(beverage);
                    return beverage;

                case CoffeeType.Frappe:
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new IceCream(beverage);
                    return beverage;

                case CoffeeType.IrishCoffee:
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Whiskey(beverage);
                    beverage = new Whip(beverage);
                    return beverage;

                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }
        }
    }
}
