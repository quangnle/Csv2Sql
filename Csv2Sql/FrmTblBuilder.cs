using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csv2Sql
{    
    public partial class FrmTblBuilder : Form
    {
        private List<DbField> _fields;
        private string _tableName;

        public TableBuilderCloseDelegate OnClosingForm;

        public FrmTblBuilder(string tableName, List<DbField> fields)
        {  
            InitializeComponent();

            _tableName = tableName;
            _fields = fields;

            var paddedHeight = 27 * _fields.Count;

            this.Height += paddedHeight;
            pnlFields.Height = paddedHeight;
            btnDone.Top += paddedHeight;

            for (int i = 0; i < _fields.Count; i++)
            {
                var uc = new FieldItem();
                pnlFields.Controls.Add(uc);
                uc.Left = 0;
                uc.Top = i * 27;
                uc.FieldName = _fields[i].Name;
                uc.FieldType = _fields[i].DbType;
                uc.FieldSize = _fields[i].Size;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {   
            if (OnClosingForm != null)
            {
                for (int i = 0; i < _fields.Count; i++)
                {
                    _fields[i].Name = ((FieldItem)pnlFields.Controls[i]).FieldName;
                    _fields[i].DbType = ((FieldItem)pnlFields.Controls[i]).FieldType;
                    _fields[i].Size = ((FieldItem)pnlFields.Controls[i]).FieldSize;
                }

                OnClosingForm(_fields);
            }

            this.Close();
        }
    }
}
