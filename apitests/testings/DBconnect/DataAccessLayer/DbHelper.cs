using System.Data.SqlClient;
namespace DBconnect.DataAccessLayer;

public class DbHelper
{
    public static SqlConnection GetConnection()
    {
        string connectionString = "Data Source=THICCPAD\\SQLEXPRESS;Initial Catalog=BridgeIT;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(connectionString);
        return connection;
    }

}
