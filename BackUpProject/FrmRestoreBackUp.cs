using BackUpProject.BackUpProjectDataCommon;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BackUpProject
{
    public partial class FrmRestoreBackUp : Form
    {
        private string? backupFilePath = null;
        private string databaseName = string.Empty;

        public FrmRestoreBackUp()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            backupFilePath = OpenBackupFile();

            if (backupFilePath == null)
            {
                MessageBox.Show("Select a backup fail.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string[] arrPath = backupFilePath.Split("\\");

            databaseName = arrPath[arrPath.Length - 1];
            string[] arrName = databaseName.Split(".");

            databaseName = arrName[0];

            textBoxBak.Text = backupFilePath;
        }
        public static string OpenBackupFile()
        {
            using var dialog = new OpenFileDialog();
            dialog.Title = "Избери .bak файл";
            dialog.Filter = "SQL Backup Files (*.bak)|*.bak";
            dialog.Multiselect = false;

            return dialog.ShowDialog() == DialogResult.OK
                ? dialog.FileName
                : null!;
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            if (backupFilePath == null) return;

            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Избери папка за .mdf и .ldf файловете";

                if (folderDialog.ShowDialog() != DialogResult.OK) return;

                string folder = folderDialog.SelectedPath;

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string connectionString = @"Server=(LocalDB)\MSSQLLocalDB;Database=master;Trusted_Connection=True;Encrypt=False;";

                RestoreDatabase(backupFilePath, connectionString);
            }
        }
        public void RestoreDatabase(string backupFilePath, string connectionString)
        {
            // 2. Папка за .mdf/.ldf
            string folder = @"D:\BackupDB\Organizer";
            Directory.CreateDirectory(folder);

            // 3. Ново име на база и файлове
            string databaseName = $"{textBoxDBName.Text}Restored";
            string dataFilePath = Path.Combine(folder, $"{textBoxDBName.Text}Restored.mdf");
            string logFilePath = Path.Combine(folder, $"{textBoxDBName.Text}Restored_log.ldf");

            string logicalData = string.Empty;
            string logicalLog = string.Empty;

            // 4. Вземане на logical имена от backup-а
            (logicalData, logicalLog) = GetLogicalNames(backupFilePath, connectionString);

            // 5. RESTORE
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            string dropSql = $@"
                    IF EXISTS (SELECT name FROM sys.databases WHERE name = N'{databaseName}')
                    BEGIN
                        ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                        DROP DATABASE [{databaseName}];
                    END";

            using var dropCmd = new SqlCommand(dropSql, connection);
            dropCmd.ExecuteNonQuery();

            string restoreSql = $@"
                RESTORE DATABASE [{databaseName}]
                FROM DISK = N'{backupFilePath}'
                WITH MOVE '{logicalData}' TO N'{dataFilePath}',
                     MOVE '{logicalLog}' TO N'{logFilePath}',
                     REPLACE,
                     RECOVERY;";
                
            using var cmd = new SqlCommand(restoreSql, connection);
            cmd.ExecuteNonQuery();

            MessageBox.Show($"DB '{databaseName}' was restored succesfully!");
        }
        public static (string dataLogical, string logLogical) GetLogicalNames(string backupFilePath, string connectionString)
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            using var cmd = new SqlCommand($"RESTORE FILELISTONLY FROM DISK = N'{backupFilePath}'", connection);
            using var reader = cmd.ExecuteReader();

            string dataLogical = null;
            string logLogical = null;

            while (reader.Read())
            {
                string type = reader["Type"].ToString()!;
                string logicalName = reader["LogicalName"].ToString()!;

                if (type == "D") // Data файл
                    dataLogical = logicalName;
                else if (type == "L") // Log файл
                    logLogical = logicalName;
            }

            if (dataLogical == null || logLogical == null)
                throw new Exception("Не можаха да се намерят logical имената на .mdf и .ldf във .bak файла.");

            return (dataLogical, logLogical);
        }
    }
}
