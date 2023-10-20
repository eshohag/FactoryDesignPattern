using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class VehicleFactory
    {
        public IVehicle GetVehicle(int typeId)
        {
            IVehicle vehicle = null;

            switch (typeId)
            {
                case (int)VehicleTypeEnum.Bike:
                    vehicle = new Bike();
                    break;
                case (int)VehicleTypeEnum.Car:
                    vehicle = new Car();
                    break;
                default:
                    break;
            }
            return vehicle;
        }
    }
}
