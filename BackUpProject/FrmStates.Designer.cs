namespace BackUpProject
{
    partial class FrmStates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewState = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dbNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Timer = new DataGridViewTextBoxColumn();
            stateIsOnDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            lastBackUpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            backUpStateBindingSource1 = new BindingSource(components);
            backUpStateBindingSource = new BindingSource(components);
            buttonUpdate = new Button();
            labelItems = new Label();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewState).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backUpStateBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backUpStateBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewState
            // 
            dataGridViewState.AutoGenerateColumns = false;
            dataGridViewState.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewState.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dbNameDataGridViewTextBoxColumn, Timer, stateIsOnDataGridViewCheckBoxColumn, lastBackUpDataGridViewTextBoxColumn });
            dataGridViewState.DataSource = backUpStateBindingSource1;
            dataGridViewState.Location = new Point(28, 74);
            dataGridViewState.Name = "dataGridViewState";
            dataGridViewState.Size = new Size(687, 241);
            dataGridViewState.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dbNameDataGridViewTextBoxColumn
            // 
            dbNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dbNameDataGridViewTextBoxColumn.DataPropertyName = "DbName";
            dbNameDataGridViewTextBoxColumn.HeaderText = "DbName";
            dbNameDataGridViewTextBoxColumn.Name = "dbNameDataGridViewTextBoxColumn";
            // 
            // Timer
            // 
            Timer.DataPropertyName = "Timer";
            Timer.HeaderText = "Timer";
            Timer.Name = "Timer";
            // 
            // stateIsOnDataGridViewCheckBoxColumn
            // 
            stateIsOnDataGridViewCheckBoxColumn.DataPropertyName = "StateIsOn";
            stateIsOnDataGridViewCheckBoxColumn.HeaderText = "StateIsOn";
            stateIsOnDataGridViewCheckBoxColumn.Name = "stateIsOnDataGridViewCheckBoxColumn";
            // 
            // lastBackUpDataGridViewTextBoxColumn
            // 
            lastBackUpDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lastBackUpDataGridViewTextBoxColumn.DataPropertyName = "LastBackUp";
            lastBackUpDataGridViewTextBoxColumn.HeaderText = "LastBackUp";
            lastBackUpDataGridViewTextBoxColumn.Name = "lastBackUpDataGridViewTextBoxColumn";
            // 
            // backUpStateBindingSource1
            // 
            backUpStateBindingSource1.DataSource = typeof(BackUpProjectDataModels.BackUpState);
            // 
            // backUpStateBindingSource
            // 
            backUpStateBindingSource.DataSource = typeof(BackUpProjectDataModels.BackUpState);
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.ActiveCaption;
            buttonUpdate.Location = new Point(752, 141);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(110, 33);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.Location = new Point(28, 364);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(39, 15);
            labelItems.TabIndex = 2;
            labelItems.Text = "Items:";
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = SystemColors.ActiveCaption;
            buttonRefresh.Location = new Point(752, 74);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(103, 34);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // FrmStates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 388);
            Controls.Add(buttonRefresh);
            Controls.Add(labelItems);
            Controls.Add(buttonUpdate);
            Controls.Add(dataGridViewState);
            MaximizeBox = false;
            Name = "FrmStates";
            Text = "FrmStates";
            Load += FrmStates_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewState).EndInit();
            ((System.ComponentModel.ISupportInitialize)backUpStateBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backUpStateBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewState;
        private BindingSource backUpStateBindingSource;
        private Button buttonUpdate;
        private Label labelItems;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dbNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Timer;
        private DataGridViewCheckBoxColumn stateIsOnDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn lastBackUpDataGridViewTextBoxColumn;
        private BindingSource backUpStateBindingSource1;
        private Button buttonRefresh;
    }
}