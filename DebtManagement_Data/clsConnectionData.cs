using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement_Data
{
    public class clsConnectionData
    {
        public static bool CheckDatabaseConnection(string ConnectionString)
        {
            return clsPrimaryFunctions.CheckDatabaseConnection(ConnectionString);
        }

        public static bool CheckCurrentDatabaseConnection()
        {
            return clsPrimaryFunctions.CheckDatabaseConnection();
        }

    }
}
