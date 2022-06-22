using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy2.DuckVoices
{
    internal class Whistle : IVoice
    {
        public string Speak()
        {
            return "weeeeee";
        }
    }
}
