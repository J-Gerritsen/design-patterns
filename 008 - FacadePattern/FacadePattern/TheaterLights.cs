using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Theater light is on");
        }

        public void Off()
        {
            Console.WriteLine("Theater light is off");
        }

        public void Dim(int value)
        {
            Console.WriteLine("Theater light is on " + value);
        }
    }
}
