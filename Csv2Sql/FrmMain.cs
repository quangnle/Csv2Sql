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
        private string _cmdInsertTemplate = "BULK INSERT {0} FROM '{1}' WITH" + Environment.NewLine +
                                      "(" + Environment.NewLine +
                                      "FIRSTROW = {2}," + Environment.NewLine +
                                      "FIELDTERMINATOR = '{3}'," + Environment.NewLine +
                                      "ROWTERMINATOR = '\\n'," + Environment.NewLine +
                                      "TABLOCK" + Environment.NewLine +
                                      ");" + Environment.NewLine;

        private string _cmdDeleteTemplate = "TRUNCATE TABLE {0};" + Environment.NewLine;

        public FrmMain()
        {
            InitializeComponent();

            cboDelimiter.SelectedIndex = 0;
            groupBox3.Enabled = false;

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

        private void btnExecute_Click(object sender, EventArgs e)
        {
            SqlTransaction tx = null;
            try
            {
                _con.Open();
                tx = _con.BeginTransaction();
                var cmd = new SqlCommand(txtCommand.Text);
                cmd.Connection = _con;
                cmd.Transaction = tx;
                cmd.ExecuteNonQuery();
                tx.Commit();
                
            }
            catch(Exception ex)
            {
                tx.Rollback();
                MessageBox.Show("Terminated due to error while performing bulk insert. Please check the error log.");
                txtOutput.Text = ex.ToString();
            }
            finally
            {
                _con.Close();
            }
        }

        private void btnLoadCsv_Click(object sender, EventArgs e)
        {
            var dlgOpenFile = new OpenFileDialog();
            DialogResult result = dlgOpenFile.ShowDialog();

            var delimiters = new char[]{ ',', '\t', ' '};

            if (result == DialogResult.OK)
            {
                _fileName = dlgOpenFile.FileName;
                var delimiter = delimiters[Math.Max(0, cboDelimiter.SelectedIndex)];
                var hasHeaders = chkHasHeaders.Checked;

                CSVLoader loader = new CSVLoader();
                var dt = loader.Load(_fileName, hasHeaders, delimiter);

                lblNRecords.Text = String.Format("{0:0,0}", dt.Rows.Count) + " records loaded";

                grdData.DataSource = dt;
                grdData.Refresh();
            }
        }

        private void cboTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_fileName))
            {
                var tableName = cboTable.SelectedItem;
                var delimiters = new char[] { ',', '\t', ' ' };
                var delimiter = delimiters[Math.Max(0, cboDelimiter.SelectedIndex)];
                var firstRow = chkHasHeaders.Checked ? 1 : 0;

                txtCommand.Text = string.Format(_cmdInsertTemplate, tableName, _fileName, firstRow, delimiter);

                if (chkClean.Checked)
                    txtCommand.Text = string.Format(_cmdDeleteTemplate, tableName) + Environment.NewLine  + txtCommand.Text;
            }
            else
            {
                MessageBox.Show("You must load input file first, please back to step 1.");
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_con != null) _con.Dispose();
        }
    }
}
