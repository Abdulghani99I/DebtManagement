using DebtManagement_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement_Business
{
    public class clsBackUpAndRestoreDataBase
    {
        public static async Task<bool> BackUp(string FolderName)
        {
            return await clsBackUpAndRestoreDatabaseData.BackUpDataBase(FolderName);
        }

        public static async Task<bool> Restore(string PathFile)
        {
            return await clsBackUpAndRestoreDatabaseData.RestoreDataBase(PathFile);
        }




    }
}
