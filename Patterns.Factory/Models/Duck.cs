using Patterns.Factory.VoiceServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory.Models
{
    internal class Duck : IDuck
    {
        public string Name { get; set; }
        public IVoice Voice { get; set; }
        public string StarSign { get; set; }
    }
}
