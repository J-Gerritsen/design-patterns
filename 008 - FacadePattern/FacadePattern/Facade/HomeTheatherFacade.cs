using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Facade
{
    internal class HomeTheatherFacade
    {
        private PopcornPopper _popcornPopper;
        private DvdPlayer _dvdPlayer;
        private Screen _screen;
        private Projector _projector;
        private TheaterLights _theaterLights;
        private Amplifier _amplifier;

        public HomeTheatherFacade(PopcornPopper popcornPopper, DvdPlayer dvdPlayer, Screen screen, Projector projector, TheaterLights theaterLights, Amplifier amplifier)
        {
            _popcornPopper = popcornPopper;
            _dvdPlayer = dvdPlayer;
            _screen = screen;
            _projector = projector;
            _theaterLights = theaterLights;
            _amplifier = amplifier;
        }

        public void WatchMovie(string movie)
        {
            _popcornPopper.On();
            _popcornPopper.Pop();
            _screen.Down();
            _projector.On();
            _projector.SetInput(_dvdPlayer);
            _projector.WideScreenMode();
            _theaterLights.On();
            _theaterLights.Dim(10);
            _amplifier.On();
            _amplifier.SetDvd(_dvdPlayer);
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            _popcornPopper.Off();
            _dvdPlayer.Off();
            _screen.Up();
            _projector.Off();
            _theaterLights.Off();
            _amplifier.Off();
        }

        public void ListenToCD()
        {

        }

        public void EndCD()
        {

        }

        public void ListenToRadio()
        {

        }

        public void EndRadio()
        {

        }
    }
}
