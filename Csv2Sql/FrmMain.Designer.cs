namespace Csv2Sql
{
    partial class FrmMain
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
            this.grdData = new System.Windows.Forms.DataGridView();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnLoadCsv = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTable = new System.Windows.Forms.ComboBox();
            this.chkClean = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNRecords = new System.Windows.Forms.Label();
            this.chkHasHeaders = new System.Windows.Forms.CheckBox();
            this.cboDelimiter = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(12, 88);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(804, 449);
            this.grdData.TabIndex = 0;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(50, 21);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 20);
            this.txtServer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Database";
            // 
            // txtDb
            // 
            this.txtDb.Location = new System.Drawing.Point(216, 21);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(100, 20);
            this.txtDb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(50, 47);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(216, 47);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(322, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 47);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnLoadCsv
            // 
            this.btnLoadCsv.Location = new System.Drawing.Point(295, 21);
            this.btnLoadCsv.Name = "btnLoadCsv";
            this.btnLoadCsv.Size = new System.Drawing.Size(94, 23);
            this.btnLoadCsv.TabIndex = 10;
            this.btnLoadCsv.Text = "LoadCSV";
            this.btnLoadCsv.UseVisualStyleBackColor = true;
            this.btnLoadCsv.Click += new System.EventHandler(this.btnLoadCsv_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(183, 19);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 12;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Table";
            // 
            // cboTable
            // 
            this.cboTable.FormattingEnabled = true;
            this.cboTable.Location = new System.Drawing.Point(56, 19);
            this.cboTable.Name = "cboTable";
            this.cboTable.Size = new System.Drawing.Size(121, 21);
            this.cboTable.TabIndex = 15;
            this.cboTable.SelectedIndexChanged += new System.EventHandler(this.cboTable_SelectedIndexChanged);
            // 
            // chkClean
            // 
            this.chkClean.AutoSize = true;
            this.chkClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClean.Location = new System.Drawing.Point(30, 45);
            this.chkClean.Name = "chkClean";
            this.chkClean.Size = new System.Drawing.Size(147, 17);
            this.chkClean.TabIndex = 16;
            this.chkClean.Text = "Clean record before insert";
            this.chkClean.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Delimiter";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.txtDb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(416, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 72);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 2: Connect";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNRecords);
            this.groupBox2.Controls.Add(this.chkHasHeaders);
            this.groupBox2.Controls.Add(this.cboDelimiter);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnLoadCsv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 72);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 1: Load File";
            // 
            // lblNRecords
            // 
            this.lblNRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRecords.Location = new System.Drawing.Point(247, 47);
            this.lblNRecords.Name = "lblNRecords";
            this.lblNRecords.Size = new System.Drawing.Size(142, 13);
            this.lblNRecords.TabIndex = 22;
            this.lblNRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkHasHeaders
            // 
            this.chkHasHeaders.AutoSize = true;
            this.chkHasHeaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasHeaders.Location = new System.Drawing.Point(74, 46);
            this.chkHasHeaders.Name = "chkHasHeaders";
            this.chkHasHeaders.Size = new System.Drawing.Size(97, 17);
            this.chkHasHeaders.TabIndex = 21;
            this.chkHasHeaders.Text = "Has headers";
            this.chkHasHeaders.UseVisualStyleBackColor = true;
            // 
            // cboDelimiter
            // 
            this.cboDelimiter.DisplayMember = "1";
            this.cboDelimiter.FormattingEnabled = true;
            this.cboDelimiter.Items.AddRange(new object[] {
            "COMMA (,)",
            "TAB (\\t)",
            "SPACE"});
            this.cboDelimiter.Location = new System.Drawing.Point(74, 21);
            this.cboDelimiter.Name = "cboDelimiter";
            this.cboDelimiter.Size = new System.Drawing.Size(215, 21);
            this.cboDelimiter.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnExecute);
            this.groupBox3.Controls.Add(this.cboTable);
            this.groupBox3.Controls.Add(this.chkClean);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(822, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 72);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3: Import";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(822, 104);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.ReadOnly = true;
            this.txtCommand.Size = new System.Drawing.Size(263, 229);
            this.txtCommand.TabIndex = 24;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(822, 362);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(263, 175);
            this.txtOutput.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(825, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Command";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(825, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Output";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 549);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdData);
            this.Name = "FrmMain";
            this.Text = "CSV Bulk Insert";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnLoadCsv;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTable;
        private System.Windows.Forms.CheckBox chkClean;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboDelimiter;
        private System.Windows.Forms.CheckBox chkHasHeaders;
        private System.Windows.Forms.Label lblNRecords;
    }
}

