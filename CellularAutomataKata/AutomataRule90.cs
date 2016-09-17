using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularAutomataKata
{
    public class AutomataRule90 : AutomataRule
    {
        private Dictionary<string, char> _rule90;

        public override void InitRule()
        {
            _rule90 = new Dictionary<string, char>();
            _rule90.Add("111", '0');
            _rule90.Add("110", '1');
            _rule90.Add("101", '0');
            _rule90.Add("100", '1');
            _rule90.Add("011", '1');
            _rule90.Add("010", '0');
            _rule90.Add("001", '1');
            _rule90.Add("000", '0');
        }

        public override char GetValue(string key) 
        {
            return _rule90[key];
        }
    }
}
