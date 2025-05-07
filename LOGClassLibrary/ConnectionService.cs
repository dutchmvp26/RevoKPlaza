using DALClassLibrary;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALClassLibrary;

namespace LOGClassLibrary
{
    public class ConnectionService
    {
        private readonly DatabaseContext databaseContext;

        public ConnectionService(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public void PerformDatavasesOperation()
        {
            SqlConnection connection = null;

            try
            {
                using (connection = databaseContext.GetConnection())
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
