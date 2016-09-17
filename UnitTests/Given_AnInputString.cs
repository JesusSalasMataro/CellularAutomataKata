using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CellularAutomataKata;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class Given_AnInputString
    {
        [TestMethod]
        public void When_InputStringIsEmpty_Then_ReturnEmptyOutput()
        {
            // ARRANGE
            CellularAutomata cellularAutomata = new CellularAutomata();
            string inputString = "";
            int steps = 5;
            List<string> expectedOutput = new List<string>();

            // ACT
            List<string> actualOutput = cellularAutomata.Run(inputString, steps);

            // ASSERT
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
