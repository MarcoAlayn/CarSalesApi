using CarSalesApi.Interfaces;
using CarSalesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CarSalesApi.Services
{
    public class CustomerService : ICustomerService
    {
        
            private readonly CarSalesDbContext _context;

            public CustomerService(CarSalesDbContext context) 
                {
                    _context = context;
                }

                public IEnumerable<Customer> GetCustomers()
                {
                    var customers = _context.Customers.FromSqlRaw("EXEC sp_Customers @Action=0").ToList();
                    return customers;
                }
        
    }
}
