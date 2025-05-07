using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALClassLibrary
{
    public class DatabaseContext
    {
        private readonly string connectionString;

        public DatabaseContext(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString(name: "DefaultConnection");
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
