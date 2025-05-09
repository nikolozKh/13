using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    public class VideoPlayer : IMediaPlayer
    {
        private int volume;

        public void Play()
        {
            Console.WriteLine("play");
        }

        public void Pause()
        {
            Console.WriteLine("pause");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        int IMediaPlayer.volume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}
