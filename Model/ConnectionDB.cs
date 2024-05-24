using System.Data.SqlClient;

namespace ApiPruebaTecnica.Model
{
    public class ConnectionDB
    {
        public static SqlConnection NewConnection()
        {
            return new SqlConnection("Data Source = DESKTOP; Initial Catalog = ALGARTECH_PRUEBATECNICA; Integrated Security = True;");
        }
    }
}
