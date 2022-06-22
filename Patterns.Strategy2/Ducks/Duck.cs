using Patterns.Strategy2.DuckVoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy2.Ducks
{
    internal class Duck
    {
        IVoice _voice;

        public Duck(IVoice voice)
        {
            _voice = voice;
        }

        public string Talk()
        {
            return _voice.Speak();
        }
    }
}
