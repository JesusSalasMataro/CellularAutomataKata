using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularAutomataKata
{
    public class CellularAutomata
    {
        AutomataRule _rule;

        public CellularAutomata(AutomataRule rule)
        {
            _rule = rule;
            _rule.InitRule();
        }

        public List<string> Run(string inputString, int steps)
        {
            List<string> output = new List<string>();
            string resultValue;

            if (inputString.Length == 0 || steps <= 0)
            {
                throw new ArgumentNullException();
            }

            output.Add(inputString);

            for (int i = 0; i < steps; i++)
            {
                resultValue = CalculateResultValue(inputString);

                output.Add(resultValue);
                inputString = resultValue;
            }

            return output;
        }

        public List<string> GetOutputScreen(List<string> actualOutput)
        {
            return actualOutput.Select(p => p.Replace('1', 'x').Replace('0', ' ')).ToList();
        }


        #region Private methods

        private char GetValue(string valueToEvaluate)
        {
            return _rule.GetValue(valueToEvaluate);
        }

        private string CalculateResultValue(string inputString)
        {
            string valueToEvaluate;
            string resultValue = "";

            for (int ii = 0; ii < inputString.Length; ii++)
            {
                valueToEvaluate = "";

                if (ii == 0)
                {
                    valueToEvaluate = "0";
                }
                else
                {
                    valueToEvaluate += inputString[ii - 1];
                }

                valueToEvaluate += inputString[ii];

                if (ii == inputString.Length - 1)
                {
                    valueToEvaluate += "0";
                }
                else
                {
                    valueToEvaluate += inputString[ii + 1];
                }

                resultValue += GetValue(valueToEvaluate).ToString();
            }

            return resultValue;
        }

        #endregion

    }
}
