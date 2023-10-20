using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Bike : IVehicle
    {
        public int NumberOfWheels()
        {
            return 10;
        }

        public string VehicleType()
        {
            return "Bike";
        }
    }
}
