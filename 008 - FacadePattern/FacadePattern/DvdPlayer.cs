using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;
        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("DVD player is on");
        }
        public void Off()
        {
            Console.WriteLine("DVD player is off");
        }
        public void Eject()
        {

        }
        public void Pause()
        {

        }
        public void Play(string movie)
        {

        }
        public void SetSurroundAudio()
        {
            Console.WriteLine("DVD player is on surround audio");
        }
        public void SetTWoChannelAudio()
        {

        }
        public void Stop()
        {

        }
    }
}
