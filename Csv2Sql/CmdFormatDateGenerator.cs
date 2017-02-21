using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csv2Sql
{
    public class CmdFormatDateGenerator : CmdGenerator
    {
        private string _cmdSetDateFormatTemplate = "SET DATEFORMAT {0};" + Environment.NewLine;

        public string FormatString { get; set; }

        public override string GetCommand()
        {
            var cmd = string.Format(_cmdSetDateFormatTemplate, FormatString);
            return cmd;
        }
    }
}
