using CarSalesApi.Interfaces;
using CarSalesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CarSalesApi.Services
{
    public class ModelSpecificationsService : IModelSpecifications
    {
        private readonly CarSalesDbContext _context;

        public ModelSpecificationsService(CarSalesDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ModelSpecification> GetModelSpecifications()
        {
            var modelSpecifications = _context.ModelSpecifications.FromSqlRaw("EXEC sp_GetAllModelSpecifications @Action=0");
            return modelSpecifications;
        }
    }
}