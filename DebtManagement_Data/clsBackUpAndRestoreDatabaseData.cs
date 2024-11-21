using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement_Data
{
    public class clsBackUpAndRestoreDatabaseData
    {

        public static async Task<bool> RestoreDataBase(string PathFile)
        {
            return await clsPrimaryFunctions.RestoreDatabase(PathFile);
        }
        
        public static async Task<bool> BackUpDataBase(string BackupFilePath)
        {
            return await clsPrimaryFunctions.BackupDatabase(BackupFilePath);
        }

    }
}
