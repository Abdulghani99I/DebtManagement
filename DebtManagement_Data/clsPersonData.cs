using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement_Data
{
    public class clsPersonData
    {
        static public bool FindPersonByID(int PersonID, ref string FullName, ref string Phone, ref string Address)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter 
                {
                    ParameterName = "@PersonID",
                    Value = PersonID,
                    DbType = DbType.Int32,
                    Direction = ParameterDirection.Input,
                },

                new SqlParameter 
                {
                    ParameterName = "@FullName",
                    Value = FullName,
                    DbType = DbType.String,
                    Size = 50,
                    Direction = ParameterDirection.Output,
                },

                new SqlParameter 
                {
                    ParameterName = "@Phone",
                    Value = Phone,
                    DbType = DbType.String,
                    Size = 50,
                    Direction = ParameterDirection.Output,
                },

                new SqlParameter 
                {
                    ParameterName = "@Address",
                    Value = Address,
                    DbType = DbType.String,
                    Size = 50,
                    Direction = ParameterDirection.Output,
                },
            };

            bool isFound = clsPrimaryFunctions.Find("FindPerson", parameters);

            if (isFound)
            {
                FullName = parameters[1].Value.ToString();
                Phone = parameters[2].Value.ToString();
                Address = parameters[3].Value.ToString();
            }

            return isFound;
        }



        /*
static public async Task<DataTable> GetAllPeopleAsync()
{
    return await clsPrimaryFunctions.GetTableAsync("SP_GetAllPeople");
}


static public async Task<int> AddPersonAsync(string Name)
{

    SqlParameter[] parameters = new SqlParameter[]
    {
        new SqlParameter("@Name", Name),
    };

    return await clsPrimaryFunctions.AddAsync("SP_AddNewPerson", parameters);
}

static public async Task<bool> UpdatePersonAsync(int PersonID, string Name)
{
    if (PersonID <= 0) return false; // check if ID Don't ture

    SqlParameter[] parameters = new SqlParameter[]
    {
        new SqlParameter("@PersonID", PersonID),
        new SqlParameter("@Name", Name),
    };

    return await clsPrimaryFunctions.UpdateAsync("SP_UpdatePerson", parameters);
}

static public async Task<bool> DeletePersonByIDAsync(int PersonID)
{
    SqlParameter parameters = new SqlParameter("@PersonID", PersonID);

    return await clsPrimaryFunctions.DeleteAsync("SP_DeletePersonByID", parameters);
}
*/

    }
}
