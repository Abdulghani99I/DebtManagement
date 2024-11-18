using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtManagement_Data
{
    public class clsSettingsUserData
    {
        static public bool FindSettingsUserByUser(ref int SettingsUserID, ref string CompanyName, ref string CompanyDescription, ref string PictureData, ref int ConversionValue)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {

                new SqlParameter {
                    ParameterName = "@SettingsUserID",
                    DbType = DbType.Int32,
                    Direction = ParameterDirection.Output,
                },

                new SqlParameter {
                    ParameterName = "@CompanyName",
                    DbType = DbType.String,
                    Direction = ParameterDirection.Output,
                    Size = 100,
                },

                new SqlParameter {
                    ParameterName = "@CompanyDescription",
                    DbType = DbType.String,
                    Direction = ParameterDirection.Output,
                    Size = 500,
                    IsNullable = true
                },

                new SqlParameter {
                    ParameterName = "@PictureData",
                    DbType = DbType.String,
                    Direction = ParameterDirection.Output,
                    Size = 10240000,
                    IsNullable = true
                },


                new SqlParameter {
                    ParameterName = "@ConversionValue",
                    DbType = DbType.Int32,
                    Direction = ParameterDirection.Output
                },
            };

            bool isFound = clsPrimaryFunctions.Find("GetSettings", parameters);

            if (isFound)
            {
                SettingsUserID = Convert.ToInt32(parameters[0].Value);
                CompanyName = (parameters[1].Value).ToString();
                CompanyDescription = (parameters[2].Value).ToString();
                PictureData = (parameters[3].Value).ToString();
                ConversionValue = Convert.ToInt32(parameters[4].Value);
            }

            return isFound;
        }


        static public async Task<bool> UpdateSettingsAsync(string UserName, string CompanyName, string CompanyDescription, string PictureData, int ConversionValue)
        {

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CompanyName", CompanyName),
                new SqlParameter("@CompanyDescription", CompanyDescription),
                new SqlParameter("@PictureData", PictureData),
                new SqlParameter("@ConversionValue", ConversionValue),
            };

            return await clsPrimaryFunctions.UpdateAsync("UpdateSettings", parameters);
        }

        /*
               static public async Task<int> AddSettingsUserAsync(string Name)
               {

                   SqlParameter[] parameters = new SqlParameter[]
                   {
                       new SqlParameter("@Name", Name),
                   };

                   return await clsPrimaryFunctions.AddAsync("SP_AddNewSettingsUser", parameters);
               }



               static public async Task<bool> DeleteSettingsUserByIDAsync(int SettingsUserID)
               {
                   SqlParameter parameters = new SqlParameter("@SettingsUserID", SettingsUserID);

                   return await clsPrimaryFunctions.DeleteAsync("SP_DeleteSettingsUserByID", parameters);
               }
               */


    }
}
