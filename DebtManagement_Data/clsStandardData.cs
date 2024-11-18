using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement_Data
{
    internal class clsStandardData
    {
        /*
.        {
            return await clsPrimaryFunctions.GetTableAsync("SP_GetAllPeople");
        }

        static public bool FindStandardByID(int StandardID, ref string Name)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter {
                    ParameterName = "@StandardID",
                    Value = StandardID,
                    DbType = DbType.Int32,
                    Direction = ParameterDirection.Input,
                },

                new SqlParameter {
                    ParameterName = "@Name",
                    Value = Name,
                    DbType = DbType.String,
                    Size = 50,
                    Direction = ParameterDirection.Output,
                },
            };

            bool isFound = clsPrimaryFunctions.Find("SP_FindStandardByID", parameters);

            if (isFound)
            {
                Name = parameters[1].Value.ToString();
            }

            return isFound;
        }

        static public async Task<int> AddStandardAsync(string Name)
        {

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", Name),
            };

            return await clsPrimaryFunctions.AddAsync("SP_AddNewStandard", parameters);
        }

        static public async Task<bool> UpdateStandardAsync(int StandardID, string Name)
        {
            if (StandardID <= 0) return false; // check if ID Don't ture

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@StandardID", StandardID),
                new SqlParameter("@Name", Name),
            };

            return await clsPrimaryFunctions.UpdateAsync("SP_UpdateStandard", parameters);
        }

        static public async Task<bool> DeleteStandardByIDAsync(int StandardID)
        {
            SqlParameter parameters = new SqlParameter("@StandardID", StandardID);

            return await clsPrimaryFunctions.DeleteAsync("SP_DeleteStandardByID", parameters);
        }
        */
    }
}
