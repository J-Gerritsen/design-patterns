using FacadePattern.Facade;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);

            HomeTheatherFacade homeTheather = new HomeTheatherFacade(popcornPopper, dvdPlayer, screen, projector, lights, amp);

            homeTheather.WatchMovie("Die Hard");
            homeTheather.EndMovie();

            
        }
    }
}