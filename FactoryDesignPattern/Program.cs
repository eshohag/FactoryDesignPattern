namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vehicleFactory =new VehicleFactory();
            //IVehicle vehicle = vehicleFactory.GetVehicle("Car");
            IVehicle vehicle = vehicleFactory.GetVehicle("Bike");

            Console.WriteLine($"VehicleType {vehicle.VehicleType()} & Number of Wheels {vehicle.NumberOfWheels()}");
            Console.ReadKey();
        }
    }
}
