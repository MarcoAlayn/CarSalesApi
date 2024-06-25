// Services/CarService.cs
using CarSalesApi.Interfaces;
using CarSalesApi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CarSalesApi.Services
{
    public class CarService : ICarService
    {
        private readonly CarSalesDbContext _context;

        public CarService(CarSalesDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetCars()
        {
            // Using raw SQL to call the stored procedure
            var cars = _context.Cars.FromSqlRaw("EXEC sp_GetAllCars").ToList();
            return cars;
        }

        public Car GetCar(Guid guid)
        {
            return _context.Cars.Find(guid);
        }

        public Car AddCar(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
            return car;
        }

        public void UpdateCar(Guid guid, Car car)
        {
            var existingCar = _context.Cars.Find(guid);
            if (existingCar != null)
            {
                // Update properties here
                _context.SaveChanges();
            }
        }

        public void DeleteCar(Guid guid)
        {
            var car = _context.Cars.Find(guid);
            if (car != null)
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
        }
    }
}
