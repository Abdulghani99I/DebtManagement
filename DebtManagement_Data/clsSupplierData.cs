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

        static public async Task<int> AddSupplierAsync(string FullName, string Phone, string Address)
        {

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FullName", FullName),
                new SqlParameter("@Phone", Phone),
                new SqlParameter("@Address", Address),
            };

            return await clsPrimaryFunctions.AddAsync("AddSupplier", parameters);
        }
        static public async Task<bool> UpdateSupplierAsync(int SupplierID, string FullName, string Phone, string Address)
        {
            if (SupplierID <= 0) return false; // check if ID Don't ture

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SupplierID", SupplierID),
                new SqlParameter("@FullName", FullName),
                new SqlParameter("@Phone", Phone),
                new SqlParameter("@Address", Address),
            };

            return await clsPrimaryFunctions.UpdateAsync("UpdateSupplier", parameters);
        }

        static public bool FindSupplierByID(int SupplierID, ref int PersonID, ref Decimal BalanceDinar, ref DateTime CreatedAt)
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
                ParameterName = "@PersonID",
                Value = PersonID,
                DbType = DbType.Int32,
                Direction = ParameterDirection.Output,
            },

            new SqlParameter {
                ParameterName = "@BalanceDinar",
                Value = BalanceDinar,
                DbType = DbType.Decimal,
                Direction = ParameterDirection.Output,
            },

            new SqlParameter {
                ParameterName = "@CreatedAt",
                Value = CreatedAt,
                DbType = DbType.DateTime,
                Direction = ParameterDirection.Output,
            },

            };

            bool isFound = clsPrimaryFunctions.Find("FindSupplier", parameters);

            if (isFound)
            {
                if (parameters[1].Value != DBNull.Value)
                    PersonID =  Convert.ToInt32(parameters[1].Value);

                if (parameters[2].Value != DBNull.Value)
                    BalanceDinar = Convert.ToDecimal(parameters[2].Value);
                
                if (parameters[3].Value != DBNull.Value)
                    CreatedAt = Convert.ToDateTime(parameters[3].Value);
            }

            return isFound;
        }

        static public async Task<bool> DeleteSupplierByIDAsync(int SupplierID)
        {
            SqlParameter parameters = new SqlParameter("@SupplierID", SupplierID);

            return await clsPrimaryFunctions.DeleteAsync("DeleteSupplierByID", parameters);
        }
    }
}
