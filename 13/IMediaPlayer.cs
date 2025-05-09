using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal interface IMediaPlayer
    {
        void Play();
        void Pause();
        void Stop();
        int volume { get; set; }
    }
}
