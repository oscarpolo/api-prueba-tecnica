using ApiPruebaTecnica.Entities;
using ApiPruebaTecnica.Model;
using System.Data.SqlClient;

namespace ALGARTECH_PRUEBATECNICA.Services
{
    public class CyclingStoreService
    {
        private readonly ConnectionDB _connectionDB;
        public CyclingStoreService(ConnectionDB connectionDB) 
        {
            _connectionDB = connectionDB;
        }

        public IEnumerable<ProductsDTO> ProductsFiltered(ProductByNameDto productByNameDto)
        {
            CyclingStoreModel cyclingStoreModel = new(_connectionDB);
            return cyclingStoreModel.ProductsByNameModel(productByNameDto);
        }

        public IEnumerable<ClientsDto> ClientFiltered(ClientByIdDto clientByIdDto)
        {
            CyclingStoreModel cyclingStoreModel = new(_connectionDB);
            return cyclingStoreModel.ClientFilteredModel(clientByIdDto);
        }

        public bool CreateNewOrder(NewOrderDto newOrderDto)
        {
            CyclingStoreModel cyclingStoreModel = new(_connectionDB);
            return cyclingStoreModel.CreateNewOrderModel(newOrderDto);
        }
    }
}
