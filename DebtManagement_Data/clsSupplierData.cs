using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement_Data
{
    public  class clsSupplierData
    {
            
        static public async Task<DataTable> GetAllSuppliersAsync()
        {
            return await clsPrimaryFunctions.GetTableAsync("GetAllSuppliers");
        }
        /*
        static public bool FindSupplierByID(int SupplierID, ref string Name)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter {
            ParameterName = "@SupplierID",
            Value = SupplierID,
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

            bool isFound = clsPrimaryFunctions.Find("SP_FindSupplierByID", parameters);

            if (isFound)
            {
                Name = parameters[1].Value.ToString();
            }

            return isFound;
        }

        static public async Task<int> AddSupplierAsync(string Name)
        {

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Name", Name),
            };

            return await clsPrimaryFunctions.AddAsync("SP_AddNewSupplier", parameters);
        }

        static public async Task<bool> UpdateSupplierAsync(int SupplierID, string Name)
        {
            if (SupplierID <= 0) return false; // check if ID Don't ture

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@SupplierID", SupplierID),
        new SqlParameter("@Name", Name),
            };

            return await clsPrimaryFunctions.UpdateAsync("SP_UpdateSupplier", parameters);
        }

        static public async Task<bool> DeleteSupplierByIDAsync(int SupplierID)
        {
            SqlParameter parameters = new SqlParameter("@SupplierID", SupplierID);

            return await clsPrimaryFunctions.DeleteAsync("SP_DeleteSupplierByID", parameters);
        }


        */
    }
}
