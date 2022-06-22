using Patterns.Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    internal class TruckAdapter : IVehicle
    {
        // this class pretty much just maps the methods needed by IVehicle into methods on the truck class

        private Truck _truck;

        public TruckAdapter()
        {
            _truck = new Truck();
        }

        public void GoForward()
        {
            _truck.Go();
        }

        public void Start()
        {
            _truck.EngineOn(true);
        }

        public void Stop()
        {
            _truck.EngineOn(false);
        }
    }
}
