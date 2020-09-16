using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cshape_PlayMP3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(@"C:\Test\piano2.wav");
            soundPlayer.Play();
            Thread.Sleep(10000);
        }
    }
}
