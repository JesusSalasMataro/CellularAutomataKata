using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularAutomataKata
{
    class Program
    {
        static void Main(string[] args)
        {
            CellularAutomata automata = new CellularAutomata(new AutomataRule30());
            string input = "00000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000";            
            int steps = 20;

            List<string> output = automata.Run(input, steps);
            output = automata.GetOutputScreen(output);

            foreach (string fila in output) 
            {
                Console.WriteLine(fila);
            }

            Console.ReadLine();
        }
    }
}
