using ApiPruebaTecnica.Entities;
using Dapper;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace ApiPruebaTecnica.Model
{
    public class CyclingStoreModel
    {
        private readonly SqlConnection sqlConnection;
        private readonly ConnectionDB _connectionDB;

        public CyclingStoreModel(ConnectionDB connectionDB)
        {
            _connectionDB = connectionDB;
            sqlConnection = _connectionDB.NewConnection();
        }

        public IEnumerable<ProductsDTO> ProductsByNameModel(ProductByNameDto name)
        {
            sqlConnection.Open();
            var response = sqlConnection.Query<ProductsDTO>("ProductsByName @Nombre", new { Nombre = name.Name });
            sqlConnection.Close();
            return response;
        }

        public IEnumerable<ClientsDto> ClientFilteredModel(ClientByIdDto id)
        {
            sqlConnection.Open();
            var response = sqlConnection.Query<ClientsDto>("PA_CostumerById @DocumentId", new { DocumentId = id.Id });
            sqlConnection.Close();
            return response;
        }

        public bool CreateNewOrderModel(NewOrderDto newOrder)
        {
            sqlConnection.Open();
            string jsonData = JsonConvert.SerializeObject(newOrder.ProductsOrder);
            int totalAmount = newOrder.ProductsOrder.Sum(x => x.Total);
            var response = sqlConnection.Query("PA_CreateNewOrder @CustomerAddress, @CustomerID, @TotalAmount, @JsonProductsOrder", new { newOrder.CustomerAddress, newOrder.CustomerID, TotalAmount = totalAmount, JsonProductsOrder = jsonData });
            sqlConnection.Close();
            return response != null;
        }
    }
}
