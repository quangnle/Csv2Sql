using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csv2Sql
{
    public class CmdBuilder
    {
        private List<CmdGenerator> _generators;

        public CmdBuilder()
        {
            _generators = new List<CmdGenerator>();
        }

        public CmdBuilder AddCommand(CmdGenerator generator)
        {
            _generators.Add(generator);
            return this;
        }

        public string GetCommand()
        {
            var cmd = "";
            for (int i = 0; i < _generators.Count; i++)
            {
                cmd += _generators[i].GetCommand() + Environment.NewLine;
            }

            return cmd;
        }
    }
}
