using BackUpProject.BackUpProjectData;
using BackUpProject.BackUpProjectDataCommon;
using BackUpProject.BackUpProjectDataModels;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
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
        string mdfPath = string.Empty;

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
            lsFiles.Clear();
            textBoxDBName.Text = string.Empty;
            textBoxSourcePath.Text = string.Empty;
            textBoxDestPath.Text = string.Empty;
            comboBoxTime.Text = string.Empty;
            comboBoxTimeType.Text = string.Empty;
        }
        private void buttonBrowseSourcePath_Click(object sender, EventArgs e)
        {
            Open();

            textBoxSourcePath.Text = mdfPath;
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

                    mdfPath = mdf!;

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
        private void buttonBackUp_Click(object sender, EventArgs e)
        {
            FrmStates frmStates = new FrmStates();
            frmStates.Show();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string dbName = textBoxDBName.Text;
            time = 0;
            string timeType = string.Empty;

            if (comboBoxTime.Text == "" || comboBoxTimeType.Text == "")
            {
                MessageBox.Show("Please set a timer.");
                return;
            }
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
                //break;
            }
            context.SaveChanges();

            if (comboBoxTime.Text != "")
            {
                time = Convert.ToInt32(comboBoxTime.Text);
            }
            if (comboBoxTimeType.Text != "")
            {
                timeType = comboBoxTimeType.Text;
            }
            BackUpState backUpState = new BackUpState
            {
                DbName = dbName,
                LastBackUp = DateTime.Now,
                StateIsOn = true,
                Time = time,
                TimeType = timeType,
            };

            context.Add(backUpState);
            context.SaveChanges();

            ClearFields();

            MessageBox.Show("Database added successfully.");
        }

        private void buttonSetTimer_Click(object sender, EventArgs e)
        {
            List<int> lsIds = new List<int>();

            string timeType = string.Empty;

            if (comboBoxTime.Text != "")
            {
                time = int.Parse(comboBoxTime.Text);
                timeType = comboBoxTimeType.Text;

                //if (timeType == "Min")
                //{
                //    time *= 60000;
                //}
                //else if (timeType == "Hour")
                //{
                //    time *= 3600000;
                //}
            }
            if (time > 0)
            {

                var ids = context.BackUpStates!.Select(id => new { id.Id }).ToList();
                lsIds = ids.Select(i => i.Id).ToList();

                foreach (var id in lsIds)
                {
                    Update(id, "Time", time, "TimeType", timeType);
                }
            }
            MessageBox.Show("Timer set successfully.");
        }
        public void Update(int id, string columnTime, int timeValue, string columnTimeType, string typeTimeValue)
        {
            string connectionString = null!;
            connectionString = DbConfig.ConnectionString;

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            try
            {
                using (cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    string sqlCommand = $"Update BackUpStates set {columnTime}=@{columnTime}, {columnTimeType}=@{columnTimeType} Where Id={id}";
                    cmd = new SqlCommand(sqlCommand, cnn);
                    cmd.Parameters.AddWithValue($"@{columnTime}", timeValue);
                    cmd.Parameters.AddWithValue($"@{columnTimeType}", typeTimeValue);
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
            SqlDbBackup sqlDbBackup = new SqlDbBackup();

            var dbNames = context.PathToBackUps!.Select(n => new { n.Name, n.LocFrom, n.LocTo }).ToHashSet();

            foreach (var db in dbNames)
            {
                var getState = context.BackUpStates!.Select(t => new { t.DbName, t.StateIsOn, t.Time, t.TimeType, t.LastBackUp }).Where(n => n.DbName == db.Name);

                bool timerState = getState.Select(s => s.StateIsOn).FirstOrDefault();

                int time = getState.Select(s => s.Time).FirstOrDefault();

                string timeType = getState.Select(s => s.TimeType).FirstOrDefault()!;

                var lastBackUp = getState.Select(s => s.LastBackUp).FirstOrDefault();

                DateTime now = DateTime.Now;
                TimeSpan interval = new TimeSpan();

                if (timerState)
                {
                    if (timeType == "Min")
                    {
                        interval = TimeSpan.FromMinutes(time);
                    }
                    else if (timeType == "Hour")
                    {
                        interval = TimeSpan.FromHours(time);
                    }

                    if (DateTime.Now - lastBackUp > interval)
                    {
                        sqlDbBackup.BackupDatabase(connectionString, db.Name, db.LocTo);

                        var backUpState = context.BackUpStates!.FirstOrDefault(b => b.DbName == db.Name);

                        backUpState!.LastBackUp = DateTime.Now;

                        context.Update(backUpState);
                        context.SaveChanges();
                    }
                }
            }
            MessageBox.Show("Automatic Backup Completed.");
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            FrmRestoreBackUp frmRestoreBackUp = new FrmRestoreBackUp();
            frmRestoreBackUp.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIconBackUp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIconBackUp.ContextMenuStrip = contextMenuStrip1;

            this.Show();

            MaxmizedFromTray();
        }
        private void MinimzedTray()
        {
            notifyIconBackUp.Visible = true;
            notifyIconBackUp.Icon = SystemIcons.Application;

            notifyIconBackUp.BalloonTipText = "Minimized";

            notifyIconBackUp.ShowBalloonTip(500);
        }

        private void MaxmizedFromTray()
        {
            notifyIconBackUp.Visible = true;
            notifyIconBackUp.BalloonTipText = "Maximized";

            notifyIconBackUp.ShowBalloonTip(500);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIconBackUp.Visible = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIconBackUp.Visible = true;
                this.Hide();
                e.Cancel = true;
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                MinimzedTray();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                MaxmizedFromTray();
            }
        }
    }
}
