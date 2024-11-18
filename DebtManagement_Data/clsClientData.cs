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
    public  class clsClientData
    {
            
        static public async Task<DataTable> GetAllClientsAsync()
        {
            return await clsPrimaryFunctions.GetTableAsync("GetAllClients");
        }

          
        static public async Task<object ?> GetTotalClientsDebtAsync()
        {
            return await clsPrimaryFunctions.ExecuteScalarAsync("TotalClientsDebt");
        }

        static public async Task<object ?> GetTotalClientsPaymentsAsync()
        {
            return await clsPrimaryFunctions.ExecuteScalarAsync("TotalClientsPayments");
        }

        static public async Task<DataTable> GetClientDebtByClientIDAsync(int ClientID)
        {
            SqlParameter parameter = new SqlParameter("@ClientID", ClientID);

            return await clsPrimaryFunctions.GetTableAsync("GetClientDebtByClientID", parameter);
        }

        static public async Task<DataTable> GetClientPaymentsByClientIDAsync(int ClientID)
        {
            SqlParameter parameter = new SqlParameter("@ClientID", ClientID);
                
            return await clsPrimaryFunctions.GetTableAsync("GetClientPaymentsByClientID", parameter);
        }

        static public async Task<int> AddClientAsync(string FullName, string Phone, string Address)
        {

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FullName", FullName),
                new SqlParameter("@Phone", Phone),
                new SqlParameter("@Address", Address),
            };

            return await clsPrimaryFunctions.AddAsync("AddClient", parameters);
        }
        
        static public async Task<bool> UpdateClientAsync(int ClientID, string FullName, string Phone, string Address)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ClientID", ClientID),
                new SqlParameter("@FullName", FullName),
                new SqlParameter("@Phone", Phone),
                new SqlParameter("@Address", Address),
            };

            return await clsPrimaryFunctions.UpdateAsync("UpdateClient", parameters);
        }
        
        static public async Task<bool> UpdateClientDebtAsync(int DebtMenuID, string MenuName, decimal Amount)
        {
            if (DebtMenuID <= 0) return false; // check if ID Don't ture

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DebtMenuID", DebtMenuID),
                new SqlParameter("@MenuName", MenuName),
                new SqlParameter("@Amount", Amount),
            };

            return await clsPrimaryFunctions.UpdateAsync("UpdateClientDebtMenu", parameters);
        }

        static public bool FindClientByID(int ClientID, ref int PersonID, ref Decimal BalanceDinar, ref DateTime CreatedAt)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter {
                ParameterName = "@ClientID",
                Value = ClientID,
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

            bool isFound = clsPrimaryFunctions.Find("FindClient", parameters);

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


        static public bool FindClientDebtMenuByDebtMenuID(int DebtMenuID, ref string MenuName, ref Decimal Amount)
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

            bool isFound = clsPrimaryFunctions.Find("FindClientDebtMenuByDebtMenuID", parameters);

            if (isFound)
            {

                MenuName = parameters[1].Value.ToString();

                Amount = Convert.ToDecimal(parameters[2].Value);
            }

            return isFound;
        }



        static public async Task<bool> DeleteClientByIDAsync(int ClientID)
        {
            SqlParameter parameters = new SqlParameter("@ClientID", ClientID);

            return await clsPrimaryFunctions.DeleteAsync("DeleteClientByID", parameters);
        }

        static public async Task<bool> ResetClientDebtAndPaymentsAsync(int ClientID)
        {
            SqlParameter parameters = new SqlParameter("@ClientID", ClientID);

            return await clsPrimaryFunctions.DeleteAsync("ResetClientDebtAndPaymentsByClientID", parameters);
        }

        static public async Task<bool> DeleteClientDebtAsync(int DebtMenuID)
        {
            SqlParameter parameters = new SqlParameter("@DebtMenuID", DebtMenuID);

            return await clsPrimaryFunctions.DeleteAsync("DeleteClientDebtByDebtMenuID", parameters);
        }


        static public async Task<bool> DeleteClientPaymentAsync(int PaymentID)
        {
            SqlParameter parameters = new SqlParameter("@PaymentID", PaymentID);

            return await clsPrimaryFunctions.DeleteAsync("DeleteClientPaymentByPaymentID", parameters);
        }


        static public async Task<int> AddClientDebtMenuAsync(int ClientID, string MenuName, Decimal Amount)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ClientID", ClientID),
                new SqlParameter("@MenuName", MenuName),
                new SqlParameter("@Amount", Amount),
            };

            return await clsPrimaryFunctions.AddAsync("AddClientDebtMenu", parameters);
        }


        static public async Task<int> AddClientPaymentAsync(int ClientID, decimal Amount)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ClientID", ClientID),
                new SqlParameter("@Amount", Amount),
            };

            return await clsPrimaryFunctions.AddAsync("AddClientPayment", parameters);
        }

        static public bool FindClientPaymentAsync(int PaymentID, ref decimal Amount)
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

            bool isFound = clsPrimaryFunctions.Find("FindClientPaymentByPaymentID", parameters);

            if (isFound)
            {
                if (parameters[1].Value != DBNull.Value)
                    Amount = Convert.ToInt32(parameters[1].Value);

            }

            return isFound;
        }


        static public async Task<bool> UpdateClientPaymentAsync(int PaymentID, decimal Amount)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PaymentID", PaymentID),
                new SqlParameter("@Amount", Amount),
            };

            return await clsPrimaryFunctions.UpdateAsync("UpdateClientPayment", parameters);
        }


    }
}
