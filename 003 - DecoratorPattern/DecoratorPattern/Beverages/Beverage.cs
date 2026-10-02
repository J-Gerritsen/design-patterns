using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }
    internal abstract class Beverage
    {
        public Size Size { get { return size; } set { size = value; } }
        private Size size = Size.TALL;

        protected string description = "Unknown";
        protected Beverage baseBeverage = null;
        

        public virtual string GetDescription()
        {
            return description;
        }

        protected double GetSizeCost()
        {
            if (Size == Size.TALL)
                return 0.00;

            if (Size == Size.GRANDE)
                return 0.50;
            
            return 1.00;
        }

        public abstract double cost();
    }
}
