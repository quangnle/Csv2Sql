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
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDisplayCSV = new System.Windows.Forms.Button();
            this.lblNRecords = new System.Windows.Forms.Label();
            this.chkHasHeaders = new System.Windows.Forms.CheckBox();
            this.cboDelimiter = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.chkDropExistedTbl = new System.Windows.Forms.CheckBox();
            this.rdoGenNewTbl = new System.Windows.Forms.RadioButton();
            this.rdoExistedTbl = new System.Windows.Forms.RadioButton();
            this.btnConfigureTbl = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDateFormat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(12, 168);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(837, 369);
            this.grdData.TabIndex = 0;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(50, 21);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(88, 20);
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
            this.label2.Location = new System.Drawing.Point(144, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Database";
            // 
            // txtDb
            // 
            this.txtDb.Location = new System.Drawing.Point(211, 21);
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
            this.txtUser.Size = new System.Drawing.Size(88, 20);
            this.txtUser.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(211, 47);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(314, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
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
            this.btnExecute.ForeColor = System.Drawing.Color.Green;
            this.btnExecute.Location = new System.Drawing.Point(355, 123);
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
            this.label5.Location = new System.Drawing.Point(16, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Table";
            // 
            // cboTable
            // 
            this.cboTable.FormattingEnabled = true;
            this.cboTable.Location = new System.Drawing.Point(62, 78);
            this.cboTable.Name = "cboTable";
            this.cboTable.Size = new System.Drawing.Size(139, 21);
            this.cboTable.TabIndex = 15;
            // 
            // chkClean
            // 
            this.chkClean.AutoSize = true;
            this.chkClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClean.Location = new System.Drawing.Point(216, 25);
            this.chkClean.Name = "chkClean";
            this.chkClean.Size = new System.Drawing.Size(165, 17);
            this.chkClean.TabIndex = 16;
            this.chkClean.Text = "Clean all records before insert";
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
            this.groupBox1.Controls.Add(this.btnSaveConfig);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 72);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 2: Connect";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConfig.Location = new System.Drawing.Point(314, 45);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConfig.TabIndex = 10;
            this.btnSaveConfig.Text = "Save Cfg";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDisplayCSV);
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
            // btnDisplayCSV
            // 
            this.btnDisplayCSV.Location = new System.Drawing.Point(295, 46);
            this.btnDisplayCSV.Name = "btnDisplayCSV";
            this.btnDisplayCSV.Size = new System.Drawing.Size(94, 23);
            this.btnDisplayCSV.TabIndex = 23;
            this.btnDisplayCSV.Text = "Display data";
            this.btnDisplayCSV.UseVisualStyleBackColor = true;
            this.btnDisplayCSV.Click += new System.EventHandler(this.btnDisplayCSV_Click);
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
            this.chkHasHeaders.Checked = true;
            this.chkHasHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtTableName);
            this.groupBox3.Controls.Add(this.chkDropExistedTbl);
            this.groupBox3.Controls.Add(this.rdoGenNewTbl);
            this.groupBox3.Controls.Add(this.rdoExistedTbl);
            this.groupBox3.Controls.Add(this.btnConfigureTbl);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cboDateFormat);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnExecute);
            this.groupBox3.Controls.Add(this.cboTable);
            this.groupBox3.Controls.Add(this.chkClean);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(413, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 150);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3: Configure && Import";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Name";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(261, 79);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(88, 20);
            this.txtTableName.TabIndex = 11;
            // 
            // chkDropExistedTbl
            // 
            this.chkDropExistedTbl.AutoSize = true;
            this.chkDropExistedTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDropExistedTbl.Location = new System.Drawing.Point(317, 103);
            this.chkDropExistedTbl.Name = "chkDropExistedTbl";
            this.chkDropExistedTbl.Size = new System.Drawing.Size(119, 17);
            this.chkDropExistedTbl.TabIndex = 26;
            this.chkDropExistedTbl.Text = "Drop existing table?";
            this.chkDropExistedTbl.UseVisualStyleBackColor = true;
            // 
            // rdoGenNewTbl
            // 
            this.rdoGenNewTbl.AutoSize = true;
            this.rdoGenNewTbl.Location = new System.Drawing.Point(216, 55);
            this.rdoGenNewTbl.Name = "rdoGenNewTbl";
            this.rdoGenNewTbl.Size = new System.Drawing.Size(142, 17);
            this.rdoGenNewTbl.TabIndex = 25;
            this.rdoGenNewTbl.Text = "Generate New Table";
            this.rdoGenNewTbl.UseVisualStyleBackColor = true;
            this.rdoGenNewTbl.CheckedChanged += new System.EventHandler(this.rdoGenNewTbl_CheckedChanged);
            // 
            // rdoExistedTbl
            // 
            this.rdoExistedTbl.AutoSize = true;
            this.rdoExistedTbl.Checked = true;
            this.rdoExistedTbl.Location = new System.Drawing.Point(19, 55);
            this.rdoExistedTbl.Name = "rdoExistedTbl";
            this.rdoExistedTbl.Size = new System.Drawing.Size(105, 17);
            this.rdoExistedTbl.TabIndex = 24;
            this.rdoExistedTbl.TabStop = true;
            this.rdoExistedTbl.Text = "Existing Table";
            this.rdoExistedTbl.UseVisualStyleBackColor = true;
            this.rdoExistedTbl.CheckedChanged += new System.EventHandler(this.rdoExistedTbl_CheckedChanged);
            // 
            // btnConfigureTbl
            // 
            this.btnConfigureTbl.Location = new System.Drawing.Point(353, 77);
            this.btnConfigureTbl.Name = "btnConfigureTbl";
            this.btnConfigureTbl.Size = new System.Drawing.Size(77, 23);
            this.btnConfigureTbl.TabIndex = 23;
            this.btnConfigureTbl.Text = "Configure";
            this.btnConfigureTbl.UseVisualStyleBackColor = true;
            this.btnConfigureTbl.Click += new System.EventHandler(this.btnConfigureTbl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date Format";
            // 
            // cboDateFormat
            // 
            this.cboDateFormat.FormattingEnabled = true;
            this.cboDateFormat.Items.AddRange(new object[] {
            "ddmmyy",
            "mmddyy",
            "yymmdd"});
            this.cboDateFormat.Location = new System.Drawing.Point(98, 23);
            this.cboDateFormat.Name = "cboDateFormat";
            this.cboDateFormat.Size = new System.Drawing.Size(103, 21);
            this.cboDateFormat.TabIndex = 18;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdData);
            this.Name = "FrmMain";
            this.Text = "CSV Bulk Insert Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox cboDelimiter;
        private System.Windows.Forms.CheckBox chkHasHeaders;
        private System.Windows.Forms.Label lblNRecords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDateFormat;
        private System.Windows.Forms.Button btnConfigureTbl;
        private System.Windows.Forms.CheckBox chkDropExistedTbl;
        private System.Windows.Forms.RadioButton rdoGenNewTbl;
        private System.Windows.Forms.RadioButton rdoExistedTbl;
        private System.Windows.Forms.Button btnDisplayCSV;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTableName;
    }
}

