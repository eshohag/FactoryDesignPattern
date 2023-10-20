using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class VehicleFactory
    {
        public IVehicle GetVehicle(string type)
        {
            IVehicle vehicle = null;

            switch (type.ToLower())
            {
                case "bike":
                    vehicle = new Bike();
                    break;
                case "car":
                    vehicle = new Car();
                    break;
                default:
                    break;
            }
            return vehicle;
        }
    }
}
