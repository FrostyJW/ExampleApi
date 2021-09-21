using ExampleApi.Helpers;
using ExampleApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ExampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private static CarList CarList { get; set; }
        public CarsController()
        {
            CarList = new CarList();
            CarList.Cars = new List<Car>() 
            {
                new Car(1,"ბეენწვე ტროიკა","ბეენწვე",5),
                new Car(2,"ჩეტვიორკა","ბეენწვე",4),
                new Car(3,"მერსო","მერსედესი",3),
                new Car(4,"ალფარომეო","ჯულიეტა",4)
            };
        }

        [HttpGet]
        public ApiResponse Get()
        {
            var carList = CarList.Cars;

            var result = new ApiResponse<List<Car>>()
            {
                Status = (int)HttpStatusCode.OK,
                Message = "მაგარია ძაან",
                Model = carList
            };

            return result;
        }

        [HttpGet("[action]")]
        public Car Get([FromQuery]int id,string name)
        {
            var carList = CarList.Cars;

            var getCarByIdResult = carList.Where(x => x.Id == id).FirstOrDefault();
                //.Select(y => new cr()
                //{
                //    Manufacturer = y.Manufacturer,
                //    Name = y.Name
                //}).ToList();
            //var getCarByIdResult = carList.Where(x => x.Manufacturer == "ბეენწვე").ToList();

            //var result = new ApiResponse<List<cr>>()
            //{
            //    Status = (int)HttpStatusCode.OK,
            //    Message = "მაგარია ძაან 2",
            //    Model = getCarByIdResult
            //};

            return getCarByIdResult;
        }

        [HttpPost]
        public ApiResponse Create([FromBody] CreateCar model)
        {
            var newCar = new Car()
            {
                Id = model.Id,
                Name = model.Name,
                Manufacturer = model.Manufacturer,
                WheelCount = model.WheelCount,
            };

            CarList.Cars.Add(newCar);

            var result = new ApiResponse()
            {
                Status = (int)HttpStatusCode.OK,
                Message = "წარმატებით შეინახა ",
            };

            return result;
        }
    }
}
