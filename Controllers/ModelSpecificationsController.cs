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
            try
            {

                var models = _modelSpecificationsService.GetModelSpecifications();
                return Ok(models);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al obtener las especificaciones de modelos");

            }
        }
    }
}
