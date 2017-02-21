using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csv2Sql
{
    public class CmdCreateTblGenerator : CmdGenerator
    {
        private string _cmdTemplate = "CREATE TABLE {0}({1}); \r\n";

        public string TableName { get; set; }
        public List<DbField> Fields { get; set; }

        public override string GetCommand()
        {
            var fStr = "";
            foreach (var f in Fields)
            {
                fStr += f.Name + " " + f.DbType;
                if (f.Size > 0)
                {
                     fStr += "(" + f.Size.ToString() + ")";
                }
                fStr += ",\r\n";
            }
            fStr = fStr.Substring(0, fStr.Length - 3);

            var cmd = string.Format(_cmdTemplate, TableName, fStr);
            return cmd;
        }
    }
}
