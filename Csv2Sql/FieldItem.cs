using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csv2Sql
{
    public partial class FieldItem : UserControl
    {
        public string FieldName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string FieldType
        {
            get { return cboType.Text; }
            set
            {
                var found = false;
                for (int i = 0; i < cboType.Items.Count; i++)
                {
                    if ((string)cboType.Items[i] == value)
                    {
                        found = true;
                        cboType.SelectedItem = cboType.Items[i];
                    }
                }

                if (!found) cboType.SelectedIndex = 0;
            }
        }

        public int FieldSize
        {
            get { return int.Parse(txtSize.Text); }
            set { txtSize.Text = value.ToString(); }
        }

        public FieldItem()
        {
            InitializeComponent();
            cboType.SelectedIndex = 0;
        }
    }
}
