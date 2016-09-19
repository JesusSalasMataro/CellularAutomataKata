using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellularAutomataKata
{
    public abstract class AutomataRule
    {
        public abstract char GetValue(string key);
    }
}
