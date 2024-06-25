using CarSalesApi.Models;

namespace CarSalesApi.Interfaces
{
    public interface ICarService
    {
        IEnumerable<Car> GetCars();
        Car GetCar(Guid guid);
        Car AddCar(Car car);
        void UpdateCar(Guid guid, Car car);
        void DeleteCar(Guid guid);
    }
}
