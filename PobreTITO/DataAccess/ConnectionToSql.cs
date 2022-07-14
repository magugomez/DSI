using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
         private readonly string connectionString;
         public ConnectionToSql()
         {
             connectionString = "Server=DESKTOP-TQJT2JS; database=PobreTITO; integrated security=true";
         }
         protected SqlConnection GetConnection()
         {
             return new SqlConnection(connectionString);
         }
    }
}