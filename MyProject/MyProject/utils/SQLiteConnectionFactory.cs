using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace Lab2Agentii.utils
{
    class SQLiteConnectionFactory : ConnectionFactory
    {
        public override IDbConnection createConnection()
        {
            String connectionString = "Data Source=BazaDate.db;Version=3;";
            return new SQLiteConnection(connectionString);
        }
    }
}
