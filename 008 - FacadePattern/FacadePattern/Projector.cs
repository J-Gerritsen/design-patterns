using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Projector
    {
        private DvdPlayer _dvdPlayer;
        public Projector()
        {
        }

        public void SetInput(DvdPlayer dvdPlayer)
        {
            this._dvdPlayer = dvdPlayer;
        }

        public void On()
        {
            Console.WriteLine("Projector is on");
        }

        public void Off()
        {
            Console.WriteLine("Projector is off");
        }

        public void TvMode()
        {

        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector is on widescreen mode");
        }
    }
}
