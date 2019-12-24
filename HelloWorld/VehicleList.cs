using System;
using System.Collections;
namespace HelloWorld
{
    public class VehicleList
    {
        public ArrayList list;

        public VehicleList()
        {
            list = new ArrayList();
        }

        public void Add(Vehicle vehicle)
        {
            list.Add(vehicle);
        }

        public void PrintAll()
        {
            foreach(Vehicle vehicle in list)
            {
                vehicle.PrintLine();
            }
        }
    }
}
