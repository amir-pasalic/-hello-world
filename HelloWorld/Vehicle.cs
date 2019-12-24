using System;
namespace HelloWorld
{
    public class Vehicle
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }

        public Vehicle(string Manufacturer, string Model, int Year)
        {
            this.Model = Model;
            this.Manufacturer = Manufacturer;
            this.Year = Year;
        }

        public void PrintLine()
        {
            Console.WriteLine("{0} : {1} ({2})", Manufacturer, Model, Year);
        }
    }
}
