using FacadePatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemo.Concrete
{
    public class Amplifier : SwitchBase
    {
        CdPlayer cdplayer;
        DvdPlayer dvdPlayer;
        Tuner turner;

        public void SetCD(CdPlayer cdplayer)
        {
            this.cdplayer = cdplayer;
        }

        public void SetDvd(DvdPlayer dvdPlayer)
        {
            this.dvdPlayer = dvdPlayer;
        }

        public void SetTurner(Tuner turner)
        {
            this.turner = turner;
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Playing Stereo Sound now");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Playing Surround Sound now");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine("Volume is :" + volume.ToString());
        }
    }
}
