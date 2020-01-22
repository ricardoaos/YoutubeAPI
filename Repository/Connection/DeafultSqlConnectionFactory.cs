using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Repository.Connection
{
    public class DeafultSqlConnectionFactory : IConnectionFactory
    {
        public IDbConnection Connection()
        {
            return new SqlConnection("Database=HeroDB;Data Source=(localdb)\\MSSQLLocalDB;");
        }
    }
}
