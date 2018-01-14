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

            var resultNormal = sequence.CheckTerminationCode(sequence.NORMAL_TERMINATION_CODE, TerminationCodeType.Normal);
            var resultEmergency = sequence.CheckTerminationCode(sequence.EMERGENCY_TERMINATION_CODE, TerminationCodeType.Emergency);
            var resultBothA = sequence.CheckTerminationCode(sequence.NORMAL_TERMINATION_CODE, TerminationCodeType.Emergency | TerminationCodeType.Normal);
            var resultBothB = sequence.CheckTerminationCode(sequence.EMERGENCY_TERMINATION_CODE, TerminationCodeType.Emergency | TerminationCodeType.Normal);

            Assert.IsTrue(resultNormal);
            Assert.IsTrue(resultEmergency);
            Assert.IsTrue(resultBothA);
            Assert.IsTrue(resultBothB);
        }
    }
}
