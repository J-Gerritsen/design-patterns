using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Beverage.HookedBeverages
{
    internal class SodaWithHook: CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("preparing soda syrup");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding whipped cream");
        }

        public override bool CustomerWantsCondement()
        {
            Console.WriteLine("Would you like whipped cream with your soda? (y/n)?");
            string answer = Console.ReadLine();
            return answer.ToLower().StartsWith('y');
        }
    }
}
