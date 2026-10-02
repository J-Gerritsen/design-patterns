using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        public bool IsEmpty { get { return this.empty; } }
        public bool IsBoiled { get { return this.boiled; } }


        private static ChocolateBoiler uniqueInstance = new ChocolateBoiler();

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            return uniqueInstance;
        }


        public void fill()
        {
            if(empty)
            {
                empty = false;
                boiled = false;
            }
        }

        public void drain()
        {
            if(!empty && boiled)
            {
                empty = true;
            }
        }

        public void boil()
        {
            if(!empty && !boiled)
            {
                boiled = true;
            }
        }
    }
}
