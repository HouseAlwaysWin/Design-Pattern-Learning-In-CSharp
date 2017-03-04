using FacadePatternDemo.Concrete;
using FacadePatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeTheatherFacade homeTheater = new HomeTheatherFacade();
            homeTheater.WatchMovie("Inception", PlayerBase.DvdMode);

            homeTheater.EndMovie();
        }
    }
}
