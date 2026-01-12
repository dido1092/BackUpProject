using BackUpProject.BackUpProjectData;
using BackUpProject.BackUpProjectDataCommon;
using BackUpProject.BackUpProjectDataModels;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BackUpProject
{
    public partial class Form1 : Form
    {
        private string pathToAddFiles = string.Empty;
        private string[] pathWithFile = new string[0];

        private string[] sourcePath = { };
        private string destPath = string.Empty;
        private int time = 0;

        private BackUpProjectContext context = new BackUpProjectContext();
        DbFiles dbFiles = new DbFiles();
        private List<DbFiles> lsFiles = new List<DbFiles>();

        private string connectionString = DbConfig.ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            textBoxDBName.Text = string.Empty;
            textBoxSourcePath.Text = string.Empty;
            textBoxDestPath.Text = string.Empty;
        }
        private void buttonBrowseSourcePath_Click(object sender, EventArgs e)
        {
            Open();

            textBoxSourcePath.Text = lsFiles.Select(f => f.Mdf).FirstOrDefault();
        }
        private void buttonBrowseDestPath_Click(object sender, EventArgs e)
        {
            textBoxDestPath.Text = SelectFolder();

            destPath = textBoxDestPath.Text;
        }
        private void Open()
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Избери директория с MDF/LDF";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = dialog.SelectedPath;

                    string dbName = textBoxDBName.Text;

                    var files = Directory.GetFiles(folderPath);

                    var mdf = files.FirstOrDefault(f =>
                        Path.GetFileName(f).Equals($"{dbName}.mdf", StringComparison.OrdinalIgnoreCase));

                    var ldf = files.FirstOrDefault(f =>
                        Path.GetFileName(f).EndsWith($"{dbName}.ldf", StringComparison.OrdinalIgnoreCase));

                    lsFiles.Add(new DbFiles
                    {
                        Mdf = mdf!,
                        Ldf = ldf!,
                    });
                }
            }
        }
        public static string SelectFolder()
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Избери дестинация";
                dialog.UseDescriptionForTitle = true;

                return dialog.ShowDialog() == DialogResult.OK
                    ? dialog.SelectedPath
                    : null!;
            }
        }

        //public string[] GetPath()
        //{
        //    OpenFileDialog openFileDialog1 = OpenFile();

        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        pathToAddFiles = System.IO.Path.GetDirectoryName(openFileDialog1.FileName)!;

        //        pathWithFile = openFileDialog1.FileNames;
        //    }
        //    else
        //    {
        //        pathWithFile = new string[0];
        //    }
        //    return pathWithFile;
        //}
        //private static OpenFileDialog OpenFile()
        //{
        //    OpenFileDialog openFileDialog1 = new OpenFileDialog()
        //    {
        //        InitialDirectory = @"C:\",
        //        Title = "Browse Doc Files",

        //        CheckFileExists = true,
        //        CheckPathExists = true,

        //        DefaultExt = "All Files",
        //        Filter = "All Files (*.*)|*.*",
        //        FilterIndex = 2,
        //        RestoreDirectory = true,

        //        Multiselect = true,

        //        ReadOnlyChecked = true,
        //        ShowReadOnly = true,
        //    };
        //    return openFileDialog1;
        //}

        private void buttonBackUp_Click(object sender, EventArgs e)
        {
            FrmStates frmStates = new FrmStates();
            frmStates.Show();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string dbName = textBoxDBName.Text;

            if (string.IsNullOrWhiteSpace(dbName))
            {
                MessageBox.Show("Please enter a valid database name.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxSourcePath.Text))
            {
                MessageBox.Show("Please enter a valid Source Path.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxDestPath.Text))
            {
                MessageBox.Show("Please enter a valid Destination Path.");
                return;
            }

            foreach (var f in lsFiles)
            {
                PathToBackUp pathToBackUp = new PathToBackUp
                {
                    Name = dbName,
                    LocFrom = f.Mdf,
                    LocTo = destPath,
                };
                context.Add(pathToBackUp);
            }
            context.SaveChanges();

            BackUpState backUpState = new BackUpState
            {
                DbName = dbName,
                StateIsOn = true,
            };

            context.Add(backUpState);
            context.SaveChanges();

            ClearFields();

            MessageBox.Show("Database added successfully.");
        }

        private void buttonSetTimer_Click(object sender, EventArgs e)
        {
            List<int> lsIds = new List<int>();

            time = int.Parse(comboBoxTimer.Text);

            //BackUpState backUpState = new BackUpState
            //{
            //    Timer = time,
            //};

            //context.Add(backUpState);
            //context.SaveChanges();

            //FrmStates frmStates = new FrmStates();
            if (time > 0)
            {

                var ids = context.BackUpStates!.Select(id => new { id.Id }).ToList();
                lsIds = ids.Select(i => i.Id).ToList();

                foreach (var id in lsIds)
                {
                    Update(id, "Timer", time.ToString());
                }
            }
            MessageBox.Show("Timer set successfully.");
        }
        public void Update(int id, string columnName, string getValue)
        {
            string connectionString = null!;
            connectionString = DbConfig.ConnectionString;

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            //int rowindex = dataGridViewState.CurrentRow!.Index;
            //int colindex = dataGridViewState.CurrentCell!.ColumnIndex;

            //string? columnName = dataGridViewState.Columns[colindex].HeaderText;

            //string? getValue = dataGridViewState.CurrentCell.Value!.ToString();
            //string? id = string.Empty;

            //if (idDb != 0)
            //{
            //    id = idDb.ToString();
            //}
            //else
            //{

            //    id = dataGridViewState.Rows[rowindex].Cells[0].Value!.ToString();
            //}

            try
            {
                using (cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    string sqlCommand = $"Update BackUpStates set {columnName}=@{columnName} Where Id={id}";
                    cmd = new SqlCommand(sqlCommand, cnn);
                    cmd.Parameters.AddWithValue($"@{columnName}", getValue);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerBackUp_Tick(object sender, EventArgs e)
        {
            var timerInterval = context.BackUpStates!.Select(t => new { t.Timer }).FirstOrDefault();
            timerBackUp.Interval = timerInterval!.Timer * 60000; // Convert minutes to milliseconds

            SqlDbBackup sqlDbBackup = new SqlDbBackup();

            var dbNames = context.PathToBackUps!.Select(n => new { n.Name, n.LocFrom, n.LocTo }).ToHashSet();


            foreach (var db in dbNames)
            {
                var getState = context.BackUpStates!.Select(t => new { t.DbName, t.StateIsOn }).Where(n => n.DbName == db.Name);

                bool timerState = getState.Select(s => s.StateIsOn).FirstOrDefault();

                if (timerState)
                {
                    sqlDbBackup.BackupDatabase(connectionString, db.Name, db.LocTo);
                }
            }
            MessageBox.Show("Automatic Backup Completed.");
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            FrmRestoreBackUp frmRestoreBackUp = new FrmRestoreBackUp();
            frmRestoreBackUp.Show();
        }
    }
}
