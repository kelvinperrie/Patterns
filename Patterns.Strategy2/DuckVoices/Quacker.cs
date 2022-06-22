using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy2.DuckVoices
{
    internal class Quacker : IVoice
    {
        public string Speak()
        {
            return "quack";
        }
    }
}
