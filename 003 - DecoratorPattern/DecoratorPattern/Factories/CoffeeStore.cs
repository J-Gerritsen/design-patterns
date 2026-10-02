using DecoratorPattern.Beverages;
using DecoratorPattern.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Factories
{
    internal abstract class CoffeeStore
    {
        public Beverage OrderCoffee(CoffeeType type)
        {
            Beverage beverage = CreateCoffee(type);

            return beverage;
        }

        protected abstract Beverage CreateCoffee(CoffeeType type);
    }
}
