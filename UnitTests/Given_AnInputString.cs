using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CellularAutomataKata;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class Given_AnInputString
    {
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void When_InputStringIsEmpty_Then_ReturnInputString()
        {
            // ARRANGE
            CellularAutomata cellularAutomata = new CellularAutomata();
            string inputString = "";
            int steps = 1;

            // ACT
            List<string> actualOutput = cellularAutomata.Run(inputString, steps);

            // ASSERT

        }

        [TestMethod]
        public void When_InputStringLengthIs1_Then_ReturnCorrectOutput()
        {
            // ARRANGE
            CellularAutomata cellularAutomata = new CellularAutomata();
            string inputString = "1";
            int steps = 1;
            List<string> expectedOutput = new List<string> {
                "1",
                "0"
            };

            // ACT
            List<string> actualOutput = cellularAutomata.Run(inputString, steps);

            // ASSERT
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void When_InputStringLengthIs2_Then_ReturnCorrectOutput()
        {
            // ARRANGE
            CellularAutomata cellularAutomata = new CellularAutomata();
            string inputString = "11";
            int steps = 1;
            List<string> expectedOutput = new List<string> {
                "11",
                "11"
            };

            // ACT
            List<string> actualOutput = cellularAutomata.Run(inputString, steps);

            // ASSERT
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void When_InputStringIsNotEmptyAndOneStep_Then_ReturnCorrectOutput()
        {
            // ARRANGE
            CellularAutomata cellularAutomata = new CellularAutomata();
            string inputString = "1101010";
            int steps = 1;
            List<string> expectedOutput = new List<string> {
                "1101010",
                "1100001"
            };

            // ACT
            List<string> actualOutput = cellularAutomata.Run(inputString, steps);

            // ASSERT
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void When_InputStringIsNotEmptyAndTwoSteps_Then_ReturnCorrectOutput()
        {
            // ARRANGE
            CellularAutomata cellularAutomata = new CellularAutomata();
            string inputString = "1101010";
            int steps = 2;
            List<string> expectedOutput = new List<string> {
                "1101010",
                "1100001",
                "1110010"
            };

            // ACT
            List<string> actualOutput = cellularAutomata.Run(inputString, steps);

            // ASSERT
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void When_InputStringIsNotEmptyAndSeveralSteps_Then_ReturnCorrectOutput()
        {
            // ARRANGE
            CellularAutomata cellularAutomata = new CellularAutomata();
            string inputString = "1101010";
            int steps = 5;
            List<string> expectedOutput = new List<string> {
                "1101010",
                "1100001",
                "1110010",
                "1011101",
                "0010100",
                "0100010"
            };

            // ACT
            List<string> actualOutput = cellularAutomata.Run(inputString, steps);

            // ASSERT
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
