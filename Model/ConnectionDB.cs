using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace ApiPruebaTecnica.Model
{
    public class ConnectionDB
    {
        private readonly string _connectionString;

        public ConnectionDB(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("dev");
        }

        public SqlConnection NewConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
