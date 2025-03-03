using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject2nd.Connection_String
{
    public class ConnectionString
    {
        public static void SQLDatabseConnectionString()
        {
            SqlConnection sqlConnection= new SqlConnection("Server=DESKTOP-ASRSF7U\\SQLEXPRESS;Initial Catalog=csharpdapper;integrated security=true;");
            sqlConnection.Open();
        }
    }
}
