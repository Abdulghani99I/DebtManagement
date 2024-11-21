using DebtManagement_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement_Business
{
    public class clsConnection
    {
        public async static Task<bool> CheckDatabaseConnectionAsync(string ConnectionString)
        {
            return await clsConnectionData.CheckDatabaseConnection(ConnectionString);
        }

        public async static Task<bool> CheckCurrentDatabaseConnectionAsync()
        {
            return await clsConnectionData.CheckCurrentDatabaseConnection();
        }

    }
}
