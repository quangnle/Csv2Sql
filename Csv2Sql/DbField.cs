using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csv2Sql
{
    public class DbField
    {
        public string Name { get; set; }
        public string DbType { get; set; }
        public int Size { get; set; }
    }
}
