using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    public sealed class SingletonConParam
    {
        // originally from https://csharpindepth.com/articles/singleton

        private static string? _theBestColour;

        private static SingletonConParam instance = null;
        private static readonly object padlock = new object();

        private SingletonConParam(string theBestColour)
        {
            _theBestColour = theBestColour;
        }

        public string WhatsTheBestColour()
        {
            return _theBestColour;
        }

        public static SingletonConParam Instance(string theBestColour)
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new SingletonConParam(theBestColour);
                } else
                {
                    // if we've created our singleton before, then just set the param passed through
                    _theBestColour = theBestColour;
                }
                return instance;
            }
        }
    }
}
