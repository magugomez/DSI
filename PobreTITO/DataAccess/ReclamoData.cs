using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ReclamoData : ConnectionToSql
    {
        public bool NewIncidente(string type, string description, string area, string adress)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    string sql = "select Max(id) from Usuario";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    int max = Convert.ToInt16(cmd.ExecuteNonQuery());

                    string sql1 = "select id from Usuario where user = user";
                    SqlCommand cmd1 = new SqlCommand(sql1, connection);
                    int idUsuario = Convert.ToInt16(cmd1.ExecuteNonQuery());

                    string sql2 = "select id from TipoIncidente where description = 'type' ";
                    SqlCommand cmd2 = new SqlCommand(sql2, connection);
                    int idTipo = Convert.ToInt16(cmd2.ExecuteNonQuery());

                    command.CommandText = "Insert into Reclamo (id, idTipo, idUsuario, description, location, area, datetime) " +
                        "values (max, idTipo, idUsuario, description, adress, area, datetime)";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();

                    return true;
                }
            }
        }
    }
}
