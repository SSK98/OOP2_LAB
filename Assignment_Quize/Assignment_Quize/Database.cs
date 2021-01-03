using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Assignment_Quize
{
    class Database
    {
       public static SqlConnection ConnectDB()
        {
             string connString = @"Server=DEDSEC\SQLEXPRESS;Integrated Security=true;Database=aiub_ums_j";
            SqlConnection conn = new SqlConnection(connString); 
            return conn;
        }
    }
}
