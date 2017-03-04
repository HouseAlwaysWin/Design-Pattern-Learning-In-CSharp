using FacadePatternDemo.Concrete;
using FacadePatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemo
{
    public class HomeTheatherFacade
    {
        Amplifier amp;
        Tuner tuner;
        DvdPlayer dvd;
        CdPlayer cd;
        Projector projector;
        TheaterLights lights;
        Screen screen;
        PopcornPopper popper;
        public HomeTheatherFacade()
        {
            amp = new Amplifier();
            tuner = new Tuner();
            dvd = new DvdPlayer();
            cd = new CdPlayer();
            projector = new Projector();
            lights = new TheaterLights();
            screen = new Screen();
            popper = new PopcornPopper();

            lights.Name = "TheaterLights";
            projector.Name = "Projector";
            amp.Name = "Amplifier";
            popper.Name = "Popcorn";
        }

        public void WatchMovie(string movieName, int inputMode)
        {
            Console.WriteLine("Get ready to watch a movie");


            popper.On();


            lights.On();
            lights.Dim(10);

            screen.Down();


            projector.On();
            projector.SetInputMode(inputMode);
            projector.WideScreedMode();


            amp.On();
            amp.SetDvd(dvd);
            amp.SetSurroundSound();
            amp.SetVolume(5);

            dvd.Name = movieName;
            dvd.On();
            dvd.Play();
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            popper.Off();
            lights.On();
            screen.Up();
            projector.Off();
            amp.Off();
            dvd.Stop();
            dvd.Eject();
            dvd.Off();
        }
    }
}
