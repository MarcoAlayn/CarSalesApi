// Controllers/CarController.cs
using CarSalesApi.Interfaces;
using CarSalesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarSalesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetCars()
        {
            var cars = _carService.GetCars();
            return Ok(cars);
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetCar(Guid id)
        {
            var car = _carService.GetCar(id);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }

        [HttpPost]
        public ActionResult<Car> AddCar(Car car)
        {
            _carService.AddCar(car);
            return CreatedAtAction(nameof(GetCar), new { id = car.Guid }, car);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCar(Guid id, Car car)
        {
            if (id != car.Guid)
            {
                return BadRequest();
            }
            _carService.UpdateCar(id, car);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCar(Guid id)
        {
            _carService.DeleteCar(id);
            return NoContent();
        }
    }
}
