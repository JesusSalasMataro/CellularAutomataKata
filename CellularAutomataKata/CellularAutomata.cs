using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularAutomataKata
{
    public class CellularAutomata
    {
        private Dictionary<string, char> _rule90;

        public CellularAutomata()
        {
            InitRule90();
        }

        public List<string> Run(string inputString, int steps)
        {
            List<string> output = new List<string>();
            int inputStringLength = inputString.Length;
            string valueToEvaluate, resultValue;

            if (inputStringLength == 0)
            {
                throw new ArgumentNullException();
            }

            output.Add(inputString);

            for (int i = 0; i < steps; i++)
            {
                resultValue = "";

                for (int ii = 0; ii < inputStringLength; ii++)
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

                    if (ii == inputStringLength - 1)
                    {
                        valueToEvaluate += "0";
                    }
                    else
                    {
                        valueToEvaluate += inputString[ii + 1];
                    }

                    resultValue += GetValue(valueToEvaluate).ToString();
                }

                output.Add(resultValue);
                inputString = resultValue;
            }

            return output;
        }


        #region Private methods
        
        private void InitRule90()
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

        private char GetValue(string valueToEvaluate)
        {
            return _rule90[valueToEvaluate];
        }

        #endregion
    }
}
