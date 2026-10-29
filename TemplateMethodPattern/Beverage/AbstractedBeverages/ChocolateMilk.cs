using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Beverage.AbstractedBeverages
{
    internal class ChocolateMilk: CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Warming up chocolate milk");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding whipped cream");
        }
    }
}
