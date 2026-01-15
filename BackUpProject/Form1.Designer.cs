namespace BackUpProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxSourcePath = new TextBox();
            label1 = new Label();
            buttonBrowseSourcePath = new Button();
            label2 = new Label();
            textBoxDestPath = new TextBox();
            buttonBrowseDestPath = new Button();
            comboBoxTime = new ComboBox();
            label3 = new Label();
            buttonSetTimer = new Button();
            label4 = new Label();
            textBoxDBName = new TextBox();
            buttonBackUp = new Button();
            buttonClear = new Button();
            notifyIconBackUp = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            showToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            buttonAdd = new Button();
            labelInfo = new Label();
            timerBackUp = new System.Windows.Forms.Timer(components);
            buttonRestore = new Button();
            label5 = new Label();
            comboBoxTimeType = new ComboBox();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxSourcePath
            // 
            textBoxSourcePath.Location = new Point(116, 108);
            textBoxSourcePath.Name = "textBoxSourcePath";
            textBoxSourcePath.Size = new Size(408, 23);
            textBoxSourcePath.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 112);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "Source Path";
            // 
            // buttonBrowseSourcePath
            // 
            buttonBrowseSourcePath.BackColor = SystemColors.ActiveCaption;
            buttonBrowseSourcePath.Location = new Point(538, 108);
            buttonBrowseSourcePath.Name = "buttonBrowseSourcePath";
            buttonBrowseSourcePath.Size = new Size(75, 26);
            buttonBrowseSourcePath.TabIndex = 2;
            buttonBrowseSourcePath.Text = "Browse";
            buttonBrowseSourcePath.UseVisualStyleBackColor = false;
            buttonBrowseSourcePath.Click += buttonBrowseSourcePath_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 165);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Dest Path";
            // 
            // textBoxDestPath
            // 
            textBoxDestPath.Location = new Point(116, 162);
            textBoxDestPath.Name = "textBoxDestPath";
            textBoxDestPath.Size = new Size(408, 23);
            textBoxDestPath.TabIndex = 3;
            // 
            // buttonBrowseDestPath
            // 
            buttonBrowseDestPath.BackColor = SystemColors.ActiveCaption;
            buttonBrowseDestPath.Location = new Point(538, 162);
            buttonBrowseDestPath.Name = "buttonBrowseDestPath";
            buttonBrowseDestPath.Size = new Size(75, 26);
            buttonBrowseDestPath.TabIndex = 4;
            buttonBrowseDestPath.Text = "Browse";
            buttonBrowseDestPath.UseVisualStyleBackColor = false;
            buttonBrowseDestPath.Click += buttonBrowseDestPath_Click;
            // 
            // comboBoxTime
            // 
            comboBoxTime.FormattingEnabled = true;
            comboBoxTime.Items.AddRange(new object[] { "1", "2", "3", "5", "10", "30", "60" });
            comboBoxTime.Location = new Point(116, 273);
            comboBoxTime.Name = "comboBoxTime";
            comboBoxTime.Size = new Size(61, 23);
            comboBoxTime.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 276);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 7;
            label3.Text = "Time in Min.";
            // 
            // buttonSetTimer
            // 
            buttonSetTimer.BackColor = SystemColors.ActiveCaption;
            buttonSetTimer.Location = new Point(48, 354);
            buttonSetTimer.Name = "buttonSetTimer";
            buttonSetTimer.Size = new Size(129, 34);
            buttonSetTimer.TabIndex = 6;
            buttonSetTimer.Text = "Set";
            buttonSetTimer.UseVisualStyleBackColor = false;
            buttonSetTimer.Click += buttonSetTimer_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 60);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 9;
            label4.Text = "Data Base Name";
            // 
            // textBoxDBName
            // 
            textBoxDBName.Location = new Point(216, 57);
            textBoxDBName.Name = "textBoxDBName";
            textBoxDBName.Size = new Size(308, 23);
            textBoxDBName.TabIndex = 0;
            // 
            // buttonBackUp
            // 
            buttonBackUp.BackColor = SystemColors.ActiveCaption;
            buttonBackUp.Location = new Point(694, 57);
            buttonBackUp.Name = "buttonBackUp";
            buttonBackUp.Size = new Size(127, 38);
            buttonBackUp.TabIndex = 7;
            buttonBackUp.Text = "BACK UPs";
            buttonBackUp.UseVisualStyleBackColor = false;
            buttonBackUp.Click += buttonBackUp_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.IndianRed;
            buttonClear.Location = new Point(694, 112);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(87, 34);
            buttonClear.TabIndex = 12;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // notifyIconBackUp
            // 
            notifyIconBackUp.BalloonTipTitle = "BackUpProject";
            notifyIconBackUp.ContextMenuStrip = contextMenuStrip1;
            notifyIconBackUp.Icon = (Icon)resources.GetObject("notifyIconBackUp.Icon");
            notifyIconBackUp.Text = "BackUpProject";
            notifyIconBackUp.Visible = true;
            notifyIconBackUp.MouseDoubleClick += notifyIconBackUp_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(103, 22);
            showToolStripMenuItem.Text = "Show";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ActiveCaption;
            buttonAdd.Location = new Point(389, 202);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(135, 37);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Add to DB";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(42, 431);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(28, 15);
            labelInfo.TabIndex = 14;
            labelInfo.Text = "Info";
            // 
            // timerBackUp
            // 
            timerBackUp.Enabled = true;
            timerBackUp.Interval = 60000;
            timerBackUp.Tick += timerBackUp_Tick;
            // 
            // buttonRestore
            // 
            buttonRestore.BackColor = SystemColors.ActiveCaption;
            buttonRestore.Location = new Point(694, 276);
            buttonRestore.Name = "buttonRestore";
            buttonRestore.Size = new Size(127, 29);
            buttonRestore.TabIndex = 15;
            buttonRestore.Text = "Restore BackUp";
            buttonRestore.UseVisualStyleBackColor = false;
            buttonRestore.Click += buttonRestore_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 312);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 16;
            label5.Text = "Time Type";
            // 
            // comboBoxTimeType
            // 
            comboBoxTimeType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTimeType.FormattingEnabled = true;
            comboBoxTimeType.Items.AddRange(new object[] { "Min", "Hours" });
            comboBoxTimeType.Location = new Point(116, 309);
            comboBoxTimeType.Name = "comboBoxTimeType";
            comboBoxTimeType.Size = new Size(61, 23);
            comboBoxTimeType.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 468);
            Controls.Add(comboBoxTimeType);
            Controls.Add(label5);
            Controls.Add(buttonRestore);
            Controls.Add(labelInfo);
            Controls.Add(buttonAdd);
            Controls.Add(buttonClear);
            Controls.Add(buttonBackUp);
            Controls.Add(textBoxDBName);
            Controls.Add(label4);
            Controls.Add(buttonSetTimer);
            Controls.Add(label3);
            Controls.Add(comboBoxTime);
            Controls.Add(buttonBrowseDestPath);
            Controls.Add(textBoxDestPath);
            Controls.Add(label2);
            Controls.Add(buttonBrowseSourcePath);
            Controls.Add(label1);
            Controls.Add(textBoxSourcePath);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BackUp Project";
            FormClosing += Form1_FormClosing;
            Load += Form1_Resize;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSourcePath;
        private Label label1;
        private Button buttonBrowseSourcePath;
        private Label label2;
        private TextBox textBoxDestPath;
        private Button buttonBrowseDestPath;
        private ComboBox comboBoxTime;
        private Label label3;
        private Button buttonSetTimer;
        private Label label4;
        private TextBox textBoxDBName;
        private Button buttonBackUp;
        private Button buttonClear;
        private NotifyIcon notifyIconBackUp;
        private Button buttonAdd;
        private Label labelInfo;
        private System.Windows.Forms.Timer timerBackUp;
        private Button buttonRestore;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label5;
        private ComboBox comboBoxTimeType;
    }
}
