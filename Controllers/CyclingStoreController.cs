using ALGARTECH_PRUEBATECNICA.Services;
using ApiPruebaTecnica.Entities;
using ApiPruebaTecnica.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace ApiPruebaTecnica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CyclingStoreController : ControllerBase
    {
        private readonly ConnectionDB _connectionDB;

        public CyclingStoreController(ConnectionDB connectionDB) {
            _connectionDB = connectionDB;
        }

        [HttpPost("ProductsByName")]
        public IEnumerable<ProductsDTO> ProductsByName([FromBody] ProductByNameDto req)
        {
            CyclingStoreService cyclingStoreService = new(_connectionDB);
            return cyclingStoreService.ProductsFiltered(req);
        }

        [HttpPost("ClientById")]
        public IEnumerable<ClientsDto> ClientById([FromBody] ClientByIdDto req)
        {
            CyclingStoreService cyclingStoreService = new(_connectionDB);
            return cyclingStoreService.ClientFiltered(req);
        }

        [HttpPost("NewOrder")]
        public IActionResult NewOrder([FromBody] NewOrderDto req)
        {
            CyclingStoreService cyclingStoreService = new(_connectionDB);
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
