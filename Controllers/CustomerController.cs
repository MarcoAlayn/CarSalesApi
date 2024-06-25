using CarSalesApi.Interfaces;
using CarSalesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarSalesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        
        public CustomerController(ICustomerService customerService) 
            {
                _customerService = customerService;
            }
            [HttpGet]

            public ActionResult<IEnumerable<Customer>> GetCustomer()
            {
                var customers = _customerService.GetCustomers();
                return Ok(customers);
            }
    }
}
