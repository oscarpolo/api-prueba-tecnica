using ApiPruebaTecnica.Entities;
using ApiPruebaTecnica.Model;

namespace ALGARTECH_PRUEBATECNICA.Services
{
    public class CyclingStoreService
    {
        public IEnumerable<ProductsDTO> ProductsFiltered(ProductByNameDto productByNameDto)
        {
            CyclingStoreModel cyclingStoreModel = new();
            return cyclingStoreModel.ProductsByNameModel(productByNameDto);
        }

        public IEnumerable<ClientsDto> ClientFiltered(ClientByIdDto clientByIdDto)
        {
            CyclingStoreModel cyclingStoreModel = new();
            return cyclingStoreModel.ClientFilteredModel(clientByIdDto);
        }

        public bool CreateNewOrder(NewOrderDto newOrderDto)
        {
            CyclingStoreModel cyclingStoreModel = new();
            return cyclingStoreModel.CreateNewOrderModel(newOrderDto);
        }
    }
}
