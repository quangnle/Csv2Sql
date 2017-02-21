using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csv2Sql
{
    public class CmdDropTblGenerator : CmdGenerator
    {
        private string _cmdDropTemplate = "DROP TABLE {0};\r\n";
        public string TableName { get; set; }

        public override string GetCommand()
        {
            var cmd = string.Format(_cmdDropTemplate, TableName);
            return cmd;
        }
    }
}
