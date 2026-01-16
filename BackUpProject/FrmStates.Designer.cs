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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStates));
            dataGridViewState = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dbNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            TimeType = new DataGridViewTextBoxColumn();
            stateIsOnDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            lastBackUpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            backUpStateBindingSource1 = new BindingSource(components);
            backUpStateBindingSource = new BindingSource(components);
            buttonUpdate = new Button();
            labelItems = new Label();
            buttonRefresh = new Button();
            buttonLoad = new Button();
            comboBoxIds = new ComboBox();
            label1 = new Label();
            textBoxDbName = new TextBox();
            label2 = new Label();
            comboBoxTime = new ComboBox();
            label3 = new Label();
            comboBoxTimeType = new ComboBox();
            label4 = new Label();
            buttonSet = new Button();
            comboBoxStates = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewState).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backUpStateBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backUpStateBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewState
            // 
            dataGridViewState.AllowUserToAddRows = false;
            dataGridViewState.AllowUserToDeleteRows = false;
            dataGridViewState.AutoGenerateColumns = false;
            dataGridViewState.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewState.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dbNameDataGridViewTextBoxColumn, Time, TimeType, stateIsOnDataGridViewCheckBoxColumn, lastBackUpDataGridViewTextBoxColumn });
            dataGridViewState.DataSource = backUpStateBindingSource1;
            dataGridViewState.Location = new Point(24, 119);
            dataGridViewState.Name = "dataGridViewState";
            dataGridViewState.Size = new Size(705, 241);
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
            // Time
            // 
            Time.DataPropertyName = "Time";
            Time.HeaderText = "Time";
            Time.Name = "Time";
            // 
            // TimeType
            // 
            TimeType.DataPropertyName = "TimeType";
            TimeType.HeaderText = "TimeType";
            TimeType.Name = "TimeType";
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
            buttonUpdate.Location = new Point(748, 186);
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
            labelItems.Location = new Point(24, 409);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(39, 15);
            labelItems.TabIndex = 2;
            labelItems.Text = "Items:";
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = SystemColors.ActiveCaption;
            buttonRefresh.Location = new Point(748, 119);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(103, 34);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = SystemColors.ActiveCaption;
            buttonLoad.Location = new Point(91, 45);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 29);
            buttonLoad.TabIndex = 4;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // comboBoxIds
            // 
            comboBoxIds.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIds.FormattingEnabled = true;
            comboBoxIds.Location = new Point(24, 49);
            comboBoxIds.Name = "comboBoxIds";
            comboBoxIds.Size = new Size(61, 23);
            comboBoxIds.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 31);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 6;
            label1.Text = "Id's";
            // 
            // textBoxDbName
            // 
            textBoxDbName.Location = new Point(172, 49);
            textBoxDbName.Name = "textBoxDbName";
            textBoxDbName.ReadOnly = true;
            textBoxDbName.Size = new Size(119, 23);
            textBoxDbName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 31);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Db Name";
            // 
            // comboBoxTime
            // 
            comboBoxTime.FormattingEnabled = true;
            comboBoxTime.Items.AddRange(new object[] { "1", "2", "3", "5", "12", "24", "30", "" });
            comboBoxTime.Location = new Point(297, 49);
            comboBoxTime.Name = "comboBoxTime";
            comboBoxTime.Size = new Size(75, 23);
            comboBoxTime.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 31);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 10;
            label3.Text = "Time";
            // 
            // comboBoxTimeType
            // 
            comboBoxTimeType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTimeType.FormattingEnabled = true;
            comboBoxTimeType.Items.AddRange(new object[] { "Min", "Hour" });
            comboBoxTimeType.Location = new Point(397, 49);
            comboBoxTimeType.Name = "comboBoxTimeType";
            comboBoxTimeType.Size = new Size(92, 23);
            comboBoxTimeType.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 31);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 12;
            label4.Text = "Time Type";
            // 
            // buttonSet
            // 
            buttonSet.BackColor = SystemColors.ActiveCaption;
            buttonSet.Location = new Point(647, 43);
            buttonSet.Name = "buttonSet";
            buttonSet.Size = new Size(82, 33);
            buttonSet.TabIndex = 13;
            buttonSet.Text = "Set";
            buttonSet.UseVisualStyleBackColor = false;
            buttonSet.Click += buttonSet_Click;
            // 
            // comboBoxStates
            // 
            comboBoxStates.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStates.FormattingEnabled = true;
            comboBoxStates.Items.AddRange(new object[] { "true", "false" });
            comboBoxStates.Location = new Point(505, 49);
            comboBoxStates.Name = "comboBoxStates";
            comboBoxStates.Size = new Size(85, 23);
            comboBoxStates.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 31);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 15;
            label5.Text = "States";
            // 
            // FrmStates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 457);
            Controls.Add(label5);
            Controls.Add(comboBoxStates);
            Controls.Add(buttonSet);
            Controls.Add(label4);
            Controls.Add(comboBoxTimeType);
            Controls.Add(label3);
            Controls.Add(comboBoxTime);
            Controls.Add(label2);
            Controls.Add(textBoxDbName);
            Controls.Add(label1);
            Controls.Add(comboBoxIds);
            Controls.Add(buttonLoad);
            Controls.Add(buttonRefresh);
            Controls.Add(labelItems);
            Controls.Add(buttonUpdate);
            Controls.Add(dataGridViewState);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private BindingSource backUpStateBindingSource1;
        private Button buttonRefresh;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dbNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn TimeType;
        private DataGridViewCheckBoxColumn stateIsOnDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn lastBackUpDataGridViewTextBoxColumn;
        private Button buttonLoad;
        private ComboBox comboBoxIds;
        private Label label1;
        private TextBox textBoxDbName;
        private Label label2;
        private ComboBox comboBoxTime;
        private Label label3;
        private ComboBox comboBoxTimeType;
        private Label label4;
        private Button buttonSet;
        private ComboBox comboBoxStates;
        private Label label5;
    }
}