using CarSalesApi.Interfaces;
using CarSalesApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarSalesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelSpecificationsController : ControllerBase
    {
        private readonly IModelSpecifications _modelSpecificationsService;

        public ModelSpecificationsController(IModelSpecifications modelSpecificationsService)
        {
            _modelSpecificationsService = modelSpecificationsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ModelSpecification>> GetModelSpecifications()
        {
            var models = _modelSpecificationsService.GetModelSpecifications();
            return Ok(models);
        }
    }
}
