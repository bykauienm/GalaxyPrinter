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
        public void IsOutOfRangeTestPattern1()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("1");
            
            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsFalse(pattern.IsOutOfRange(5));
        }

        [TestMethod]
        public void IsOutOfRangeTestPattern2()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("2");

            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsFalse(pattern.IsOutOfRange(5));
        }

        [TestMethod]
        public void IsOutOfRangeTestPattern3()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("3");

            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsTrue(pattern.IsOutOfRange(4));
            Assert.IsFalse(pattern.IsOutOfRange(5));
        }

        [TestMethod]
        public void IsOutOfRangeTestPattern4()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("4");

            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsFalse(pattern.IsOutOfRange(5));
        }

        [TestMethod]
        public void IsOutOfRangeTestPattern5()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("5");

            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsFalse(pattern.IsOutOfRange(5));
        }

        [TestMethod]
        public void FindPatternTest1()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("1");

            Assert.AreEqual(new PatternPyramid().GetType(), pattern.GetType());
        }

        [TestMethod]
        public void FindPatternTest2()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("2");

            Assert.AreEqual(new PatternReverse().GetType(), pattern.GetType());
        }

        [TestMethod]
        public void FindPatternTest3()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("3");

            Assert.AreEqual(new PatternDiamond().GetType(), pattern.GetType());
        }

        [TestMethod]
        public void FindPatternTest4()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("4");

            Assert.AreEqual(new PatternDiagnal().GetType(), pattern.GetType());
        }

        [TestMethod]
        public void FindPatternTest5()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("5");

            Assert.AreEqual(new PatternHorn().GetType(), pattern.GetType());
        }

        [TestMethod]
        public void PrintTest1()
        {
            var pattern = new PatternPyramid();
            var result = "*    \n**   \n***  \n**** \n*****\n";

            Assert.AreEqual(result, pattern.Print(5));
        }

        [TestMethod]
        public void PrintTest2()
        {
            var pattern = new PatternReverse();
            var result = "*****\n ****\n  ***\n   **\n    *\n";

            Assert.AreEqual(result, pattern.Print(5));
        }

        [TestMethod]
        public void PrintTest3()
        {
            var pattern = new PatternDiamond();
            var result = "  *  \n *** \n*****\n *** \n  *  \n";

            Assert.AreEqual(result, pattern.Print(5));
        }

        [TestMethod]
        public void PrintTest4()
        {
            var pattern = new PatternDiagnal();
            var result = "    *****\n   ***** \n  *****  \n *****   \n*****    \n";

            Assert.AreEqual(result, pattern.Print(5));
        }

        [TestMethod]
        public void PrintTest5()
        {
            var pattern = new PatternHorn();
            var result = "    *****\n   ****  \n  ***    \n **      \n*        \n";

            Assert.AreEqual(result, pattern.Print(5));
        }

    }
}
