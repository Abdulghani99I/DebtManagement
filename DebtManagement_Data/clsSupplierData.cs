using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
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

        static public async Task<DataTable> GetSupplierDebtBySupplierIDAsync(int SupplierID)
        {
            SqlParameter parameter = new SqlParameter("@SupplierID", SupplierID);

            return await clsPrimaryFunctions.GetTableAsync("GetSupplierDebtBySupplierID", parameter);
        }

        static public async Task<object?> GetTotalSuppliersDebt()
        {
            return await clsPrimaryFunctions.ExecuteScalarAsync("TotalSuppliersDebt");
        }

        static public async Task<object?> GetTotalSuppliersPayments()
        {
            return await clsPrimaryFunctions.ExecuteScalarAsync("TotalSuppliersPayments");
        }

        static public async Task<DataTable> GetSupplierPaymentsBySupplierIDAsync(int SupplierID)
        {
            SqlParameter parameter = new SqlParameter("@SupplierID", SupplierID);
                
            return await clsPrimaryFunctions.GetTableAsync("GetSupplierPaymentsBySupplierID", parameter);
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
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SupplierID", SupplierID),
                new SqlParameter("@FullName", FullName),
                new SqlParameter("@Phone", Phone),
                new SqlParameter("@Address", Address),
            };

            return await clsPrimaryFunctions.UpdateAsync("UpdateSupplier", parameters);
        }
        
        static public async Task<bool> UpdateSupplierDebtAsync(int DebtMenuID, string MenuName, decimal Amount)
        {
            if (DebtMenuID <= 0) return false; // check if ID Don't ture

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DebtMenuID", DebtMenuID),
                new SqlParameter("@MenuName", MenuName),
                new SqlParameter("@Amount", Amount),
            };

            return await clsPrimaryFunctions.UpdateAsync("UpdateSupplierDebtMenu", parameters);
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
                //Value = PersonID,
                DbType = DbType.Int32,
                Direction = ParameterDirection.Output,
            },

            new SqlParameter {
                ParameterName = "@BalanceDinar",
                //Value = BalanceDinar,
                DbType = DbType.Decimal,
                Direction = ParameterDirection.Output,
            },

            new SqlParameter {
                ParameterName = "@CreatedAt",
                //Value = CreatedAt,
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


        static public bool FindSupplierDebtMenuByDebtMenuID(int DebtMenuID, ref string MenuName, ref Decimal Amount)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter {
                    ParameterName = "@DebtMenuID",
                    Value = DebtMenuID,
                    DbType = DbType.Int32,
                    Direction = ParameterDirection.Input,
                },

                new SqlParameter {
                    ParameterName = "@MenuName",
                    DbType = DbType.String,
                    Size = 150,
                    Direction = ParameterDirection.Output,
                },

                new SqlParameter {
                    ParameterName = "@Amount",
                    DbType = DbType.Decimal,
                    Direction = ParameterDirection.Output,
                },

            };

            bool isFound = clsPrimaryFunctions.Find("FindSupplierDebtMenuByDebtMenuID", parameters);

            if (isFound)
            {

                MenuName = Convert.ToString(parameters[1].Value);

                Amount = Convert.ToDecimal(parameters[2].Value);
            }

            return isFound;
        }



        static public async Task<bool> DeleteSupplierByIDAsync(int SupplierID)
        {
            SqlParameter parameters = new SqlParameter("@SupplierID", SupplierID);

            return await clsPrimaryFunctions.DeleteAsync("DeleteSupplierByID", parameters);
        }

        static public async Task<bool> ResetSupplierDebtAndPaymentsAsync(int SupplierID)
        {
            SqlParameter parameters = new SqlParameter("@SupplierID", SupplierID);

            return await clsPrimaryFunctions.DeleteAsync("ResetSupplierDebtAndPaymentsBySupplierID", parameters);
        }

        static public async Task<bool> DeleteSupplierDebtAsync(int DebtMenuID)
        {
            SqlParameter parameters = new SqlParameter("@DebtMenuID", DebtMenuID);

            return await clsPrimaryFunctions.DeleteAsync("DeleteSupplierDebtByDebtMenuID", parameters);
        }


        static public async Task<bool> DeleteSupplierPaymentAsync(int PaymentID)
        {
            SqlParameter parameters = new SqlParameter("@PaymentID", PaymentID);

            return await clsPrimaryFunctions.DeleteAsync("DeleteSupplierPaymentByPaymentID", parameters);
        }


        static public async Task<int> AddSupplierDebtMenuAsync(int SupplierID, string MenuName, Decimal Amount)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SupplierID", SupplierID),
                new SqlParameter("@MenuName", MenuName),
                new SqlParameter("@Amount", Amount),
            };

            return await clsPrimaryFunctions.AddAsync("AddSupplierDebtMenu", parameters);
        }


        static public async Task<int> AddSupplierPaymentAsync(int SupplierID, decimal Amount)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SupplierID", SupplierID),
                new SqlParameter("@Amount", Amount),
            };

            return await clsPrimaryFunctions.AddAsync("AddSupplierPayment", parameters);
        }

        static public bool FindSupplierPaymentAsync(int PaymentID, ref decimal Amount)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter {
                ParameterName = "@PaymentID",
                Value = PaymentID,
                DbType = DbType.Int32,
                Direction = ParameterDirection.Input,
                },

                new SqlParameter {
                    ParameterName = "@Amount",
                    DbType = DbType.Decimal,
                    Direction = ParameterDirection.Output,
                },
            };

            bool isFound = clsPrimaryFunctions.Find("FindSupplierPaymentByPaymentID", parameters);

            if (isFound)
            {
                if (parameters[1].Value != DBNull.Value)
                    Amount = Convert.ToInt32(parameters[1].Value);

            }

            return isFound;
        }


        static public async Task<bool> UpdateSupplierPaymentAsync(int PaymentID, decimal Amount)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PaymentID", PaymentID),
                new SqlParameter("@Amount", Amount),
            };

            return await clsPrimaryFunctions.UpdateAsync("UpdateSupplierPayment", parameters);
        }


    }
}
