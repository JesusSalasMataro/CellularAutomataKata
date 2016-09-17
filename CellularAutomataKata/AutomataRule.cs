using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellularAutomataKata
{
    public abstract class AutomataRule
    {
        public abstract void InitRule();

        public abstract char GetValue(string key);
    }
}
