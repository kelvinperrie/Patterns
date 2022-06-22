using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory.VoiceServices
{
    internal class Squeeker : IVoice
    {
        public string Speak()
        {
            return "squeek";
        }
    }
}
