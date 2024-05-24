using ALGARTECH_PRUEBATECNICA.Services;
using ApiPruebaTecnica.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiPruebaTecnica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CyclingStoreController : ControllerBase
    {
        [HttpPost("ProductsByName")]
        public IEnumerable<ProductsDTO> ProductsByName([FromBody] ProductByNameDto req)
        {
            CyclingStoreService cyclingStoreService = new();
            return cyclingStoreService.ProductsFiltered(req);
        }

        [HttpPost("ClientById")]
        public IEnumerable<ClientsDto> ClientById([FromBody] ClientByIdDto req)
        {
            CyclingStoreService cyclingStoreService = new();
            return cyclingStoreService.ClientFiltered(req);
        }

        [HttpPost("NewOrder")]
        public IActionResult NewOrder([FromBody] NewOrderDto req)
        {
            CyclingStoreService cyclingStoreService = new();
            bool response = cyclingStoreService.CreateNewOrder(req);
            if (response)
            {
                return Ok(new { message = "La orden se creó exitosamente.", status = 200 });
            }
            else
            {
                return StatusCode(500, "Ocurrió un error al procesar la solicitud.");
            }
        }
    }
}
