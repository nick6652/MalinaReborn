using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MalinaReborn.Core.Players
{
    public interface IPlayer
    {
        void Play(string path);
        void Pause();
        void Stop();
    }
}
