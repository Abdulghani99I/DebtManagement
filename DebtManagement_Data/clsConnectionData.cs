using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement_Data
{
    public class clsConnectionData
    {
        public async static Task<bool> CheckDatabaseConnection(string ConnectionString)
        {
            return await clsPrimaryFunctions.CheckDatabaseConnection(ConnectionString);
        }

        public async static Task<bool> CheckCurrentDatabaseConnection()
        {
            return await clsPrimaryFunctions.CheckDatabaseConnection();
        }

    }
}
