using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackUpProject
{
    public class SqlDbBackup
    {

        public void BackupDatabase(string connectionString, string databaseName, string backupFolder)
        {
            // Създаване на папка, ако не съществува
            if (!Directory.Exists(backupFolder))
            {
                Directory.CreateDirectory(backupFolder);
            }

            // Име на backup с timestamp
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string backupFile = Path.Combine(backupFolder, $"{databaseName}_{timestamp}.bak");

            // Connection string към SQL Server Express
            connectionString = @"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;Encrypt=False;";

            // SQL команда без COMPRESSION
            string sql = $@"
                BACKUP DATABASE [{databaseName}]
                TO DISK = N'{backupFile}'
                WITH INIT";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
