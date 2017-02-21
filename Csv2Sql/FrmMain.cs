using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csv2Sql
{
    public partial class FrmMain : Form
    {
        private SqlConnection _con = null;
        private string _configFile = "config.dat";
        private string _fileName = "";
        private string _conStrTemplate = "Data Source={0};Initial Catalog={1};User Id={2}; Password = {3};";
        private DataTable _data;
        private List<DbField> _fields;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            cboDelimiter.SelectedIndex = 0;
            cboDateFormat.SelectedIndex = 0;
            groupBox3.Enabled = false;
            rdoExistedTbl.Checked = true;
            Select(false);

            var path = Directory.GetCurrentDirectory() + @"\" + _configFile;
            if (File.Exists(path))
            {
                var cfg = File.ReadAllLines(_configFile);
                txtServer.Text = cfg[0];
                txtDb.Text = cfg[1];
                txtUser.Text = cfg[2];
                txtPassword.Text = cfg[3];
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_con != null) _con.Dispose();
        }

        private void btnLoadCsv_Click(object sender, EventArgs e)
        {
            DialogResult confirm = DialogResult.None;

            if (chkHasHeaders.Checked)
                confirm = MessageBox.Show("The current setting is to open CSV with headers. Are you sure?", "Confirmation", MessageBoxButtons.OKCancel);
            else
                confirm = MessageBox.Show("The current setting is to open CSV without headers. Are you sure?", "Confirmation", MessageBoxButtons.OKCancel);

            if (confirm == DialogResult.OK)
            {
                var dlgOpenFile = new OpenFileDialog();
                DialogResult result = dlgOpenFile.ShowDialog();

                var delimiters = new char[] { ',', '\t', ' ' };

                if (result == DialogResult.OK)
                {
                    _fileName = dlgOpenFile.FileName;
                    var delimiter = delimiters[Math.Max(0, cboDelimiter.SelectedIndex)];
                    var hasHeaders = chkHasHeaders.Checked;

                    CSVLoader loader = new CSVLoader();
                    _data = loader.Load(_fileName, hasHeaders, delimiter);

                    lblNRecords.Text = String.Format("{0:0,0}", _data.Rows.Count) + " records loaded";
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _con = new SqlConnection();
            _con.ConnectionString = string.Format(_conStrTemplate, txtServer.Text, txtDb.Text, txtUser.Text, txtPassword.Text);

            try
            {
                _con.Open();
                MessageBox.Show("Connection is successfully established.");

                var lst = _con.GetSchema("Tables");
                for (int i = 0; i < lst.Rows.Count; i++)
                {
                    cboTable.Items.Add(lst.Rows[i]["TABLE_NAME"]);
                }

                cboTable.SelectedIndex = 0;
                groupBox3.Enabled = true;
                rdoExistedTbl.Checked = true;

            }
            catch (Exception)
            {
                groupBox3.Enabled = false;
                MessageBox.Show("Cannot establish connection to server.");
            }
            finally
            {
                _con.Close();
            }
        }

        private void btnDisplayCSV_Click(object sender, EventArgs e)
        {
            if (_data != null)
            {
                grdData.DataSource = _data;
                grdData.Refresh();
            }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            var lines = new string[] { txtServer.Text, txtDb.Text, txtUser.Text, txtPassword.Text };
            File.WriteAllLines(_configFile, lines);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            CmdBuilder builder = new CmdBuilder();

            var cmdFormatDate = new CmdFormatDateGenerator() { FormatString = (string)cboDateFormat.SelectedItem };
            builder.AddCommand(cmdFormatDate);

            if (rdoExistedTbl.Checked)
            {
                var cmdInsert = new CmdInsertGenerator()
                {
                    FileName = _fileName,
                    TableName = (string)cboTable.SelectedItem,
                    Delimiter = (string)cboDelimiter.SelectedItem,
                    FirstRow = chkHasHeaders.Checked ? 2 : 1
                };

                if (chkClean.Checked)
                {
                    var cmdCleanTbl = new CmdTruncateTbl() { TableName = (string)cboTable.SelectedItem };
                    builder.AddCommand(cmdCleanTbl);
                }

                builder.AddCommand(cmdInsert);
            }
            else
            {
                if (chkDropExistedTbl.Checked)
                {
                    var cmdDropTbl = new CmdDropTblGenerator() { TableName = txtTableName.Text };
                    builder.AddCommand(cmdDropTbl);
                }

                var cmdCreateTbl = new CmdCreateTblGenerator() { TableName = txtTableName.Text, Fields = _fields };
                builder.AddCommand(cmdCreateTbl);

                var cmdInsert = new CmdInsertGenerator()
                {
                    FileName = _fileName,
                    TableName = txtTableName.Text,
                    Delimiter = (string)cboDelimiter.SelectedValue,
                    FirstRow = chkHasHeaders.Checked ? 2 : 1
                };
                builder.AddCommand(cmdInsert);
            }

            var cmd = builder.GetCommand();

            var fExecutor = new FrmExecutor(_con, cmd);
            fExecutor.ShowDialog();
        }

        private void rdoExistedTbl_CheckedChanged(object sender, EventArgs e)
        {
            var checker = (RadioButton)sender;

            if (checker.Checked)
                Select(false);
        }

        private void rdoGenNewTbl_CheckedChanged(object sender, EventArgs e)
        {
            var checker = (RadioButton)sender;

            if (checker.Checked)
                Select(true);
        }

        private void Select(bool isGenerated)
        {
            cboTable.Enabled = !isGenerated;
            txtTableName.Enabled = isGenerated;
            btnConfigureTbl.Enabled = isGenerated;
        }

        private void btnConfigureTbl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTableName.Text))
            {
                MessageBox.Show("Please enter table name first.");
                txtTableName.Focus();
            }   
            else if (_data == null)
            {
                MessageBox.Show("Please load data first, back to step 1.");
            }
            else
            {
                if (_fields == null)
                    _fields = GenDbFields();

                var fBuilder = new FrmTblBuilder(txtTableName.Text, _fields);
                fBuilder.OnClosingForm = TableBuilderDone;

                fBuilder.ShowDialog(this);
            }
        }

        private List<DbField> GenDbFields()
        {
            var lst = new List<DbField>();
            for (int i = 0; i < _data.Columns.Count; i++)
            {
                var name = _data.Columns[i].ColumnName;
                var item = new DbField() { Name = name, DbType = "", Size = 0 };
                lst.Add(item);
            }

            return lst;
        }

        private void TableBuilderDone(List<DbField> fields)
        {
            _fields = fields;
        }
    }
}
