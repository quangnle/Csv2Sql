using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csv2Sql
{
    class CmdInsertGenerator : CmdGenerator
    {
        private string _cmdInsertTemplate = "BULK INSERT {0} FROM '{1}' WITH" + Environment.NewLine +
                                      "(" + Environment.NewLine +
                                      "FIRSTROW = {2}," + Environment.NewLine +
                                      "FIELDTERMINATOR = '{3}'," + Environment.NewLine +
                                      "ROWTERMINATOR = '\\n'," + Environment.NewLine +
                                      "TABLOCK" + Environment.NewLine +
                                      ");" + Environment.NewLine;

        public string TableName { get; set; }
        public string FileName { get; set; }
        public int FirstRow { get; set; }
        public string Delimiter { get; set; }

        public override string GetCommand()
        {
            var cmd = string.Format(_cmdInsertTemplate, TableName, FileName, FirstRow, Delimiter);
            return cmd;
        }
    }
}
