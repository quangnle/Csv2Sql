using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csv2Sql
{
    public class CSVLoader
    {
        public DataTable Load(string fileName, bool hasHeaders, char delimiter)
        {
            var lines = File.ReadAllLines(fileName);

            var startLine = 1;
            var headers = lines[0].Split(delimiter);
            var nHeaders = lines[0].Split(delimiter).Length;
            if (!hasHeaders)
            {
                headers = GenerateHeaders(nHeaders);
                startLine = 0;
            }

            var table = new DataTable("Result");
            for (int i = 0; i < nHeaders; i++)
            {
                var col = new DataColumn(headers[i]);
                table.Columns.Add(col);
            }

            for (int i = startLine; i < lines.Length; i++)
            {
                var dr = table.NewRow();
                var line = lines[i];
                var arr = line.Split(delimiter);

                for (int j = 0; j < nHeaders; j++)
                {
                    dr[j] = arr[j];
                }

                table.Rows.Add(dr);
            }

            return table;
        }

        private string[] GenerateHeaders(int nHeaders)
        {
            var headers = new string[nHeaders];
            for (int i = 0; i < nHeaders; i++)
            {
                headers[i] = "Header " + (i + 1).ToString();
            }

            return headers;
        }
    }
}
