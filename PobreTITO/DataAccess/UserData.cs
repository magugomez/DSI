using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class UserData : ConnectionToSql
    {
        public bool Signin(string email, string name, string userName, string password)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    string sql = @"SELECT Max(id) FROM Usuario";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    var max = Convert.ToInt16(cmd.ExecuteNonQuery());
                    
                    command.CommandText = "Insert into Usuario (id, email, name, userName, password)" +
                        "values (max, email, name, userName, password)";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    
                    
                    return true;
                }
            }
        }
        
        public bool Login(string user, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuario where user=user and password=password";
                    command.Parameters.AddWithValue("user", user);
                    command.Parameters.AddWithValue("password", password);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}

