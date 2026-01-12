namespace BackUpProject
{
    partial class FrmRestoreBackUp
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
            textBoxBak = new TextBox();
            buttonBrowse = new Button();
            buttonRestore = new Button();
            label1 = new Label();
            textBoxDBName = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxBak
            // 
            textBoxBak.Location = new Point(132, 74);
            textBoxBak.Name = "textBoxBak";
            textBoxBak.Size = new Size(401, 23);
            textBoxBak.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            buttonBrowse.BackColor = SystemColors.ActiveCaption;
            buttonBrowse.Location = new Point(539, 73);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(75, 23);
            buttonBrowse.TabIndex = 1;
            buttonBrowse.Text = "Browse";
            buttonBrowse.UseVisualStyleBackColor = false;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // buttonRestore
            // 
            buttonRestore.BackColor = SystemColors.ActiveCaption;
            buttonRestore.Location = new Point(132, 141);
            buttonRestore.Name = "buttonRestore";
            buttonRestore.Size = new Size(136, 31);
            buttonRestore.TabIndex = 2;
            buttonRestore.Text = "Restore";
            buttonRestore.UseVisualStyleBackColor = false;
            buttonRestore.Click += buttonRestore_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 77);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = ".Bak file";
            // 
            // textBoxDBName
            // 
            textBoxDBName.Location = new Point(132, 27);
            textBoxDBName.Name = "textBoxDBName";
            textBoxDBName.Size = new Size(243, 23);
            textBoxDBName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 30);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 8;
            label3.Text = "Orignal Name on DB";
            // 
            // FrmRestoreBackUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 236);
            Controls.Add(label3);
            Controls.Add(textBoxDBName);
            Controls.Add(label1);
            Controls.Add(buttonRestore);
            Controls.Add(buttonBrowse);
            Controls.Add(textBoxBak);
            MaximizeBox = false;
            Name = "FrmRestoreBackUp";
            Text = "FrmRestoreBackUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxBak;
        private Button buttonBrowse;
        private Button buttonRestore;
        private Label label1;
        private TextBox textBoxDBName;
        private Label label3;
    }
}