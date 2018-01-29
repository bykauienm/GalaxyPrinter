﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternPrint;
using PatternPrint.AsteriskPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class PatternPrinterTest
    {
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
        public void FindPatternTestIncreasePyramid()
        {
            var printer = new PatternPrinter();
            var pattern = printer.FindPattern("6");

            Assert.AreEqual(new PatternIncreasePyramid().GetType(), pattern.GetType());
        }

    }
}
