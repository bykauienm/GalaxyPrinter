using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternPrint;
using PatternPrint.AsteriskPatterns;

namespace UnitTestProject
{
    [TestClass]
    public class PrintPatternTest
    {
        [TestMethod]
        public void IsOutOfRangeTestPatternPyramid()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("1");
            
            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsFalse(pattern.IsOutOfRange(5));
        }

        [TestMethod]
        public void IsOutOfRangeTestPatternReverse()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("2");

            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsFalse(pattern.IsOutOfRange(5));
        }

        [TestMethod]
        public void IsOutOfRangeTestPatternDiamond()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("3");

            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsTrue(pattern.IsOutOfRange(4));
            Assert.IsFalse(pattern.IsOutOfRange(5));
        }

        [TestMethod]
        public void IsOutOfRangeTestPatternDiagnal()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("4");

            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsFalse(pattern.IsOutOfRange(5));
        }

        [TestMethod]
        public void IsOutOfRangeTestPatternHorn()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("5");

            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsFalse(pattern.IsOutOfRange(5));
        }

        [TestMethod]
        public void FindPatternTestPyramid()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("1");

            Assert.AreEqual(new PatternPyramid().GetType(), pattern.GetType());
        }

        [TestMethod]
        public void FindPatternTestReverse()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("2");

            Assert.AreEqual(new PatternReverse().GetType(), pattern.GetType());
        }

        [TestMethod]
        public void FindPatternTestDiamond()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("3");

            Assert.AreEqual(new PatternDiamond().GetType(), pattern.GetType());
        }

        [TestMethod]
        public void FindPatternTestDiagnal()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("4");

            Assert.AreEqual(new PatternDiagnal().GetType(), pattern.GetType());
        }

        [TestMethod]
        public void FindPatternTestHorn()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("5");

            Assert.AreEqual(new PatternHorn().GetType(), pattern.GetType());
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

    }
}
