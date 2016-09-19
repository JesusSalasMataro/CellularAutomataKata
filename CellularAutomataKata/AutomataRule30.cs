using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularAutomataKata
{
    public class AutomataRule30 : AutomataRule
    {
        private Dictionary<string, char> _rule30;

        public AutomataRule30()
        {
            _rule30 = new Dictionary<string, char>();
            _rule30.Add("111", '0');
            _rule30.Add("110", '0');
            _rule30.Add("101", '0');
            _rule30.Add("100", '1');
            _rule30.Add("011", '1');
            _rule30.Add("010", '1');
            _rule30.Add("001", '1');
            _rule30.Add("000", '0');
        }

        public override char GetValue(string key) 
        {
            return _rule30[key];
        }
    }
}
