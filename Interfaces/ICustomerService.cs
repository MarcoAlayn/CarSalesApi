using CarSalesApi.Models;

namespace CarSalesApi.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();

    }
}
