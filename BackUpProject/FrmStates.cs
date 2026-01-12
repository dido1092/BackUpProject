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
    public partial class FrmStates : Form
    {
        private int idDb = 0;
        public FrmStates()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //string connectionString = null;
            //connectionString = DbConfig.ConnectionString;

            //SqlConnection cnn = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = cnn;

            //int rowindex = dataGridViewState.CurrentRow!.Index;
            //int colindex = dataGridViewState.CurrentCell!.ColumnIndex;

            Update(idDb);
        }
        public void Update(int idDb)
        {
            string connectionString = null;
            connectionString = DbConfig.ConnectionString;

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            int rowindex = dataGridViewState.CurrentRow!.Index;
            int colindex = dataGridViewState.CurrentCell!.ColumnIndex;

            string? columnName = dataGridViewState.Columns[colindex].HeaderText;

            string? getValue = dataGridViewState.CurrentCell.Value!.ToString();
            string? id = string.Empty;

            if (idDb != 0)
            {
                id = idDb.ToString();
            }
            else
            {

                id = dataGridViewState.Rows[rowindex].Cells[0].Value!.ToString();
            }

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
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            States(DbConfig.ConnectionString);
            CountRows();
        }

        private void States(string connectionString)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BackUpStates", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "BackUpStates");
            dataGridViewState.DataSource = ds.Tables["BackUpStates"]?.DefaultView;
        }
        private void CountRows()
        {
            int recordCount = dataGridViewState.RowCount;

            labelItems.Text = $"Rows: {recordCount - 1}"; // -1 for empty row.
        }

        private void FrmStates_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
