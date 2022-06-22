using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter.Models
{
    internal interface IVehicle
    {
        void Start();

        void Stop();

        void GoForward();
    }
}
