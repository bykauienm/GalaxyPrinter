using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternPrint;
using PatternPrint.AsteriskPatterns;

namespace UnitTestProject
{
    [TestClass]
    public class PrintPatternTest
    {
        [DataTestMethod]
        [DataRow(0, true)]
        [DataRow(5, false)]
        [DataRow(101, true)]
        public void IsOutOfRangeTestPatternPyramid(int number, bool isValid)
        {
            var pattern = new PatternPyramid();
            
            Assert.AreEqual(pattern.IsOutOfRange(number), isValid);
        }

        [DataTestMethod]
        [DataRow(0, true)]
        [DataRow(5, false)]
        [DataRow(101, true)]
        public void IsOutOfRangeTestPatternReverse(int number, bool isValid)
        {
            var pattern = new PatternReverse();

            Assert.AreEqual(pattern.IsOutOfRange(number), isValid);
        }

        [DataTestMethod]
        [DataRow(0, true)]
        [DataRow(4, true)]
        [DataRow(5, false)]
        [DataRow(101, true)]
        public void IsOutOfRangeTestPatternDiamond(int number, bool isValid)
        {
            var pattern = new PatternDiamond();

            Assert.AreEqual(pattern.IsOutOfRange(number), isValid);
        }

        [DataTestMethod]
        [DataRow(0, true)]
        [DataRow(5, false)]
        [DataRow(101, true)]
        public void IsOutOfRangeTestPatternDiagnal(int number, bool isValid)
        {
            var pattern = new PatternDiagnal();

            Assert.AreEqual(pattern.IsOutOfRange(number), isValid);
        }

        [DataTestMethod]
        [DataRow(0, true)]
        [DataRow(5, false)]
        [DataRow(101, true)]
        public void IsOutOfRangeTestPatternHorn(int number, bool isValid)
        {
            var pattern = new PatternHorn();

            Assert.AreEqual(pattern.IsOutOfRange(number), isValid);
        }

        [DataTestMethod]
        [DataRow(0, true)]
        [DataRow(5, false)]
        [DataRow(101, true)]
        public void IsOutOfRangeTestPatternIncreasePyramid(int number, bool isValid)
        {
            var pattern = new PatternIncreasePyramid();

            Assert.AreEqual(pattern.IsOutOfRange(number), isValid);
        }

        [TestMethod]
        public void PrintTestPyramid()
        {
            var pattern = new PatternPyramid();
            var result = "*    \n**   \n***  \n**** \n*****\n";

            Assert.AreEqual(result, pattern.Print(5));
        }

        [TestMethod]
        public void PrintTestReverse()
        {
            var pattern = new PatternReverse();
            var result = "*****\n ****\n  ***\n   **\n    *\n";

            Assert.AreEqual(result, pattern.Print(5));
        }

        [TestMethod]
        public void PrintTestDiamond()
        {
            var pattern = new PatternDiamond();
            var result = "  *  \n *** \n*****\n *** \n  *  \n";

            Assert.AreEqual(result, pattern.Print(5));
        }

        [TestMethod]
        public void PrintTestDiagnal()
        {
            var pattern = new PatternDiagnal();
            var result = "    *****\n   ***** \n  *****  \n *****   \n*****    \n";

            Assert.AreEqual(result, pattern.Print(5));
        }

        [TestMethod]
        public void PrintTestHorn()
        {
            var pattern = new PatternHorn();
            var result = "    *****\n   ****  \n  ***    \n **      \n*        \n";

            Assert.AreEqual(result, pattern.Print(5));
        }

        [TestMethod]
        public void PrintTestIncreasePyramid()
        {
            var pattern = new PatternIncreasePyramid();
            var result = "*\n\n* \n**\n\n*  \n** \n***\n\n";

            Assert.AreEqual(result, pattern.Print(3));
        }

    }
}
