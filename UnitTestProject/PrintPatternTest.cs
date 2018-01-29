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
            var pattern = new PatternPyramid();

            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsFalse(pattern.IsOutOfRange(5));
        }

        [TestMethod]
        public void IsOutOfRangeTestPatternReverse()
        {
            var pattern = new PatternReverse();

            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsFalse(pattern.IsOutOfRange(5));
        }

        [TestMethod]
        public void IsOutOfRangeTestPatternDiamond()
        {
            var pattern = new PatternDiamond();

            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsTrue(pattern.IsOutOfRange(4));
            Assert.IsFalse(pattern.IsOutOfRange(5));
        }

        [TestMethod]
        public void IsOutOfRangeTestPatternDiagnal()
        {
            var pattern = new PatternDiagnal();

            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsFalse(pattern.IsOutOfRange(5));
        }

        [TestMethod]
        public void IsOutOfRangeTestPatternHorn()
        {
            var pattern = new PatternHorn();

            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsFalse(pattern.IsOutOfRange(5));
        }

        [TestMethod]
        public void IsOutOfRangeTestPatternIncreasePyramid()
        {
            var pattern = new PatternIncreasePyramid();

            Assert.IsTrue(pattern.IsOutOfRange(0));
            Assert.IsTrue(pattern.IsOutOfRange(101));
            Assert.IsFalse(pattern.IsOutOfRange(5));
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
