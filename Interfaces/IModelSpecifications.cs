using CarSalesApi.Models;

namespace CarSalesApi.Interfaces
{
    public interface IModelSpecifications
    {
        IEnumerable<ModelSpecification> GetModelSpecifications();
    }
}
