using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csv2Sql
{
    public class CmdTruncateTbl : CmdGenerator
    {
        private string _cmdTruncateTemplate = "TRUNCATE TABLE {0};" + Environment.NewLine;

        public string TableName { get; set; }

        public override string GetCommand()
        {
            var cmd = string.Format(_cmdTruncateTemplate, TableName);
            return cmd;
        }
    }
}
