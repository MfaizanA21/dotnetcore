using DBconnect.Models;
using System.Data;
using System.Data.SqlClient;

namespace DBconnect.DataAccessLayer;

public class DALAuth
{
    public static void RegisterUser(Users user)
    {
        using (SqlConnection connection = DbHelper.GetConnection())
        {
            string storedProcedure = "InsertUser";
            SqlCommand command = new SqlCommand(storedProcedure, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", user.Name);
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@Role", user.Role);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public static void RegisterStudent(Students student)
    {
        int lastUid = GetUserId();
        using (SqlConnection connection = DbHelper.GetConnection())
        {
            string storedProcedure = "InsertStudent";
            SqlCommand command = new SqlCommand(storedProcedure, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Uid", lastUid);
            command.Parameters.AddWithValue("@Skills", student.Skills);
            command.Parameters.AddWithValue("@RollNumber", student.RollNumber);
            command.Parameters.AddWithValue("@Program", student.Program);
            command.Parameters.AddWithValue("@Address", student.address);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public static int GetUserId()
    {
        using (SqlConnection connection = DbHelper.GetConnection())
        {
            string query = "select MAX(Uid) from Users";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            var result = command.ExecuteScalar();
            return result == DBNull.Value ? 0 : Convert.ToInt32(result);
        }
    }
}
