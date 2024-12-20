﻿
using System.Data;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;


namespace DebtManagement_Data
{
    internal class clsPrimaryFunctions
    {
        //public static void EntireInfoToEventLoge(string Information)
        //{
        //    //Attendance And OverTime System
        //    string SourceName = "AAOTS";
        //    if (!EventLog.SourceExists(SourceName))
        //    {
        //        EventLog.CreateEventSource(SourceName, "Application");
        //    }

        //    EventLog.WriteEntry(SourceName, Information, EventLogEntryType.Error);

        //}

        public static async Task<DataTable> GetTableAsync(string procedureName, SqlParameter[] parameters = null)
        {
            DataTable resultData = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    command.CommandType = CommandType.StoredProcedure; // Specify that this is a stored procedure

                    try
                    {
                        await connection.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                resultData.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log the error message if needed
                        // EntireInfoToEventLoge(ex.Message);
                    }
                }
            }

            return resultData;
        }

        public static async Task<object?> ExecuteScalarAsync(string procedureName)
        {

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {


                    command.CommandType = CommandType.StoredProcedure; // Specify that this is a stored procedure

                    try
                    {
                        await connection.OpenAsync();
                        
                        return await command.ExecuteScalarAsync();
                    }
                    catch (Exception ex)
                    {
                        return null;
                        // Log the error message if needed
                        // EntireInfoToEventLoge(ex.Message);
                    }
                }
            }

        }



        public static async Task<DataTable> GetTableAsync(string procedureName, SqlParameter parameters)
        {
            DataTable resultData = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.Add(parameters);
                    }

                    command.CommandType = CommandType.StoredProcedure; // Specify that this is a stored procedure

                    try
                    {
                        await connection.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                resultData.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log the error message if needed
                        // EntireInfoToEventLoge(ex.Message);
                    }
                }
            }

            return resultData;
        }

        static private bool isParametersNotEqualNull(SqlParameter[] parameters)
        {
            foreach (SqlParameter parameter in parameters)
            {
                
                if (parameter.Value == null || Convert.IsDBNull(parameter.Value)  && !parameter.IsNullable)
                    return false;
            }

            return true;
        }

        public static bool Find(string procedureName, SqlParameter[] parameters)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters if they are provided
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();


                        isFound = isParametersNotEqualNull(parameters);

                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception as needed
                    }
                }
            }

            return isFound;
        }


        public static async Task<int> AddAsync(string procedureName, SqlParameter[] parameters)
        {
            int returnValue = -1; // Default value if nothing is returned

            // Use 'using' for proper disposal of the connection
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                // Prepare the SqlCommand for the stored procedure
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add provided parameters (if any)
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    // Define a return value parameter
                    SqlParameter returnParameter = new SqlParameter
                    {
                        ParameterName = "@ReturnValue",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.ReturnValue
                    };
                    command.Parameters.Add(returnParameter);

                    try
                    {
                        await connection.OpenAsync();

                        // Execute the stored procedure
                        await command.ExecuteNonQueryAsync();

                        // Safely retrieve the return value
                        if (returnParameter.Value != DBNull.Value)
                        {
                            returnValue = (int)returnParameter.Value;
                        }
                    }
                    catch (Exception ex)
                    {
                        //// Log the exception properly, for example:
                        //LogError(ex); // Assuming LogError is a custom method to log errors

                        //// Optionally rethrow the exception after logging
                        //throw;
                    }
                }
            }

            // Return the result (-1 if nothing was returned, or the actual return value)
            return returnValue;
        }

        public static async Task<bool> UpdateAsync(string procedureName, SqlParameter[] parameters)
        {
            try
            {
                // Use 'using' for proper disposal of connection
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    await connection.OpenAsync(); // Open connection asynchronously

                    // Use 'using' for proper disposal of command
                    using (SqlCommand command = new SqlCommand(procedureName, connection))
                    {
                        // Specify that this command is a stored procedure
                        command.CommandType = CommandType.StoredProcedure;

                        // Add provided parameters (if any)
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        // Execute the command and check how many rows were affected
                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        // Return true if at least one row was affected
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (assuming LogError is a method for logging)
                //LogError(ex); // This can be replaced with your logging mechanism

                // Return false to indicate failure
                return false;
            }
        }


        public static async Task<bool> DeleteAsync(string NameProcedure, SqlParameter parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(NameProcedure, connection))
                    {
                        // Indicate this is a stored procedure
                        command.CommandType = CommandType.StoredProcedure;

                        // Add the primary key as a parameter
                        command.Parameters.Add(parameters);

                        // Execute the command
                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        // If rows are affected, the delete was successful
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }


        public async static Task<bool> CheckDatabaseConnection(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();  // Try to open the connection
                    return connection.State == System.Data.ConnectionState.Open; // Return true if the connection is open
                }
                catch (SqlException)
                {
                    return false; // Return false if there was an error
                }
            }
        }


        public async static  Task<bool> CheckDatabaseConnection()
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                try
                {
                    await connection.OpenAsync();  // Try to open the connection
                    return connection.State == ConnectionState.Open; // Return true if the connection is open
                }
                catch (SqlException)
                {
                    return false; // Return false if there was an error
                }
            }
        }

        public static async Task<bool> BackupDatabase (string backupFolderPath)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    // Open the SQL connection
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand("BackupCurrentDatabase", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add the @BackupFolderPath parameter
                        command.Parameters.AddWithValue("@BackupFolderPath", backupFolderPath);

                        // Execute the command
                        await command.ExecuteNonQueryAsync();

                        // If we reach this point, the backup was successful
                        return true;

                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public static async Task<bool> RestoreDatabase (string BackupFilePath)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    // Open the SQL connection
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand("USE master; EXEC RestoreDatabase @BackupFilePath", connection))
                    {
                        // Add the @BackupFolderPath parameter
                        command.Parameters.AddWithValue("@BackupFilePath", BackupFilePath);

                        // Execute the command
                        await command.ExecuteNonQueryAsync();

                        // If we reach this point, the backup was successful
                        return true;

                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

}
