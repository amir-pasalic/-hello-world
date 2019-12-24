using System;

namespace HelloWorld
{

    class Program
    {
        public static VehicleList vehicleList = new VehicleList();

        static void Main(string[] args)
        {
            vehicleList.Add(new Vehicle("Opel", "Astra", 2003));
            vehicleList.Add(new Vehicle("Opel", "Corsa", 2010));
            vehicleList.Add(new Vehicle("Opel", "Combo", 2010));

            vehicleList.PrintAll();
        }
    }
}
