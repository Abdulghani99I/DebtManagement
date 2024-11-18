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
        public static bool CheckDatabaseConnection(string ConnectionString)
        {
            return clsConnectionData.CheckDatabaseConnection(ConnectionString);
        }

        public static bool CheckCurrentDatabaseConnection()
        {
            return clsConnectionData.CheckCurrentDatabaseConnection();
        }

    }
}
