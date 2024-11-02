using Microsoft.IdentityModel.Protocols;
using System;
using System.Configuration;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement_Data
{
    internal class clsDataAccessSettings
    {
        public static string connectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DebtManagement"].ConnectionString;
            }
        }


    }
}
