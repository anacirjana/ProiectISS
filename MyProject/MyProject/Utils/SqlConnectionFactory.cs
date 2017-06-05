using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyProject.Utils
{
    class SQLiteConnectionFactory : ConnectionFactory
    {
        public override IDbConnection createConnection()
        {
           // string connectionString = "Data Source=DESKTOP-NVKMTUP\\MSSQLSERVER01;" +
            //"Initial Catalog = ProiectISS; Integrated Security = True";

            string connectionString = "Data Source=DESKTOP-DMVLDS4\\SQLEXPRESS;" +
           "Initial Catalog = ProiectISS; Integrated Security = True";
            return new SqlConnection(connectionString);
        }
    }
}
