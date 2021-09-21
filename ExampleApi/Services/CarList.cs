using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApi.Services
{
    public class CarList
    {
        public List<Car> Cars { get; set; }
        public CarList()
        {
            this.Cars = new List<Car>();
        }
    }


    public class Car
    {
        public Car()
        {

        }
        public Car(int id, string name, string manufacturer, int wheelCount)
        {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            WheelCount = wheelCount;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int WheelCount { get; set; }
    }

    public class cr
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
    }

    public class CreateCar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int WheelCount { get; set; }
    }

    public class UpdateCar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int WheelCount { get; set; }
    }
}
