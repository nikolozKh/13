using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    using System.Collections;

    public class AudioPlayer : IMediaPlayer, IEnumerable
    {
        private string[] playlist = {"song1", "song2"};
        private int volume;

        public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Pause()
        {
            Console.WriteLine("Pause");   
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

        public IEnumerator GetEnumerator()
        {
            return playlist.GetEnumerator();
        }
    }

}