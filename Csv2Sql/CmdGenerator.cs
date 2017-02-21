using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csv2Sql
{
    public abstract class CmdGenerator
    {
        public abstract string GetCommand();
    }
}
