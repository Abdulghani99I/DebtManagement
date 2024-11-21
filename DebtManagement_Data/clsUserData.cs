using Microsoft.CodeAnalysis;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement_Data
{
    public class clsUserData
    {
        
        static public async Task<DataTable> GetAllUsersAsync()
        {
            return await clsPrimaryFunctions.GetTableAsync("GetAllUsers");
        }

        static public bool FindUserByID(int UserID, ref string FullName, ref string UserName, ref string Password, ref bool isManager)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter {
                    ParameterName = "@UserID",
                    Value = UserID,
                    DbType = DbType.Int32,
                    Direction = ParameterDirection.Input,
                },

                new SqlParameter {
                    ParameterName = "@FullName",
                    DbType = DbType.String,
                    Size = 50,
                    Direction = ParameterDirection.Output,
                },
                
                new SqlParameter {
                    ParameterName = "@UserName",
                    DbType = DbType.String,
                    Size = 50,
                    Direction = ParameterDirection.Output,
                },

                new SqlParameter {
                    ParameterName = "@Password",
                    DbType = DbType.String,
                    Size = 50,
                    Direction = ParameterDirection.Output,
                },

                new SqlParameter {
                    ParameterName = "@isManager",
                    DbType = DbType.Boolean,
                    Direction = ParameterDirection.Output,
                },
            };

            bool isFound = clsPrimaryFunctions.Find("FindUserByUserID", parameters);

            if (isFound)
            {
                FullName = parameters[1].Value.ToString();
                UserName = parameters[2].Value.ToString();
                Password = parameters[3].Value.ToString();
                bool.TryParse(parameters[4].Value.ToString(), out isManager);
            }

            return isFound;
        }


        static public bool FindUserByUserName(string UserName, ref int UserID, ref string FullName, ref string Password, ref bool isManager)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter {
                    ParameterName = "@UserName",
                    Value = UserName,
                    DbType = DbType.String,
                    Direction = ParameterDirection.Input,
                },

                
                new SqlParameter {
                    ParameterName = "@UserID",
                    DbType = DbType.Int32,
                    Direction = ParameterDirection.Output,
                },

                new SqlParameter {
                    ParameterName = "@FullName",
                    DbType = DbType.String,
                    Size = 50,
                    Direction = ParameterDirection.Output,
                },
                new SqlParameter {
                    ParameterName = "@Password",
                    DbType = DbType.String,
                    Size = 50,
                    Direction = ParameterDirection.Output,
                },
                new SqlParameter {
                    ParameterName = "@isManager",
                    DbType = DbType.Boolean,
                    Direction = ParameterDirection.Output,
                },
            };

            bool isFound = clsPrimaryFunctions.Find("FindUserByUserName", parameters);

            if (isFound)
            {
                int.TryParse(parameters[1].Value.ToString(), out UserID);
                FullName = parameters[2].Value.ToString();
                Password = parameters[3].Value.ToString();
                bool.TryParse(parameters[4].Value.ToString(), out isManager);
            }

            return isFound;
        }


        static public async Task<int> AddUserAsync(string FullName, string UserName, string Password, bool IsManager)
        {

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FullName", FullName),
                new SqlParameter("@UserName", UserName),
                new SqlParameter("@Password", Password),
                new SqlParameter("@IsManager", IsManager),
            };

            return await clsPrimaryFunctions.AddAsync("AddUser", parameters);
        }

        static public async Task<bool> UpdateUserAsync(int UserID, string FullName, string UserName, string Password, bool isManager)
        {
            if (UserID <= 0) return false; // check if ID Don't ture

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", UserID),
                new SqlParameter("@FullName", FullName),
                new SqlParameter("@UserName", UserName),
                new SqlParameter("@Password", Password),
                new SqlParameter("@isManager", isManager),
            };

            return await clsPrimaryFunctions.UpdateAsync("UpdateUserByUserID", parameters);
        }
       

        static public async Task<bool> DeleteUserByIDAsync(int UserID)
        {
            SqlParameter parameters = new SqlParameter("@UserID", UserID);

            return await clsPrimaryFunctions.DeleteAsync("DeleteUserByUserID", parameters);
        }

    }
}
