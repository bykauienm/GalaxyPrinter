using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternPrint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class SequenceManagementTest
    {
        [TestMethod]
        public void CheckTerminationCodeTest()
        {
            var sequence = new SequenceManagement();

            var resultNormal = sequence.CheckTerminationCode("0");

            Assert.IsTrue(resultNormal);
        }
    }
}
