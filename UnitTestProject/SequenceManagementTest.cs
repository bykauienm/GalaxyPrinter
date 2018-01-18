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
        public void CheckTerminationCodeNormalTest()
        {
            var sequence = new SequenceManagement();

            var resultNormal = sequence.CheckTerminationCode("Q", TerminationCodeType.Normal);

            Assert.IsTrue(resultNormal);
        }

        [TestMethod]
        public void CheckTerminationCodeEmergencyTest()
        {
            var sequence = new SequenceManagement();

            var resultEmergency = sequence.CheckTerminationCode("0", TerminationCodeType.Emergency);

            Assert.IsTrue(resultEmergency);
        }

        [TestMethod]
        public void CheckTerminationCodeBothTest()
        {
            var sequence = new SequenceManagement();

            var resultBothA = sequence.CheckTerminationCode("Q", TerminationCodeType.Emergency | TerminationCodeType.Normal);
            var resultBothB = sequence.CheckTerminationCode("0", TerminationCodeType.Emergency | TerminationCodeType.Normal);

            Assert.IsTrue(resultBothA);
            Assert.IsTrue(resultBothB);
        }
    }
}
