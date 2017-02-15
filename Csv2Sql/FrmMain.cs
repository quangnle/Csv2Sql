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

namespace Sql2Csv
{
    public partial class FrmMain : Form
    {

        private SqlConnection _con = null;
        private string configFile = "config.dat";

        public FrmMain()
        {
            InitializeComponent();
            var path = Directory.GetCurrentDirectory() + @"\" + configFile;
            if (File.Exists(path))
            {
                var cfg = File.ReadAllLines(configFile);
                txtServer.Text = cfg[0];
                txtDb.Text = cfg[1];
                txtUser.Text = cfg[2];
                txtPwd.Text = cfg[3];
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {   
            _con = new SqlConnection();
            var conStr = "Data Source={0};Initial Catalog={1};User Id={2}; Password = {3};";
            _con.ConnectionString = string.Format(conStr, txtServer.Text, txtDb.Text, txtUser.Text, txtPwd.Text);

            try
            {
                _con.Open();
                MessageBox.Show("Connection is successfully established.");

                txtQuery.Enabled = true;
                btnExecute.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot establish connection to server.");
            }
            finally
            {
                _con.Close();
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(txtQuery.Text);
                cmd.Connection = _con;

                _con.Open();

                var reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                grdData.DataSource = dt;
                grdData.Refresh();

                lblNRow.Text = "Row Count = " + dt.Rows.Count.ToString();

                _con.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _con.Close();
            }
            
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSaveFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = dlgSaveFile.FileName;
                var dt = grdData.DataSource as DataTable;
                StringBuilder sb = new StringBuilder();

                IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
                                                  Select(column => column.ColumnName);
                sb.AppendLine(string.Join(",", columnNames));

                foreach (DataRow row in dt.Rows)
                {
                    IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                    sb.AppendLine(string.Join(",", fields));
                }

                File.WriteAllText(fileName, sb.ToString());
            }
        }
    }
}
