using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrint
{
    [Flags]
    public enum TerminationCodeType
    {
        Normal = 1,
        Emergency = 2
    }

    public class SequenceManagement
    {
        public static string NormalTerminationCode { get; private set; } = "Q";
        public static string EmergencyTerminationCode { get; private set; } = "0";

        public bool CheckTerminationCode(string inputCode, TerminationCodeType type)
        {
            if ((type & TerminationCodeType.Normal) == TerminationCodeType.Normal)
            {
                if (inputCode.Equals(NormalTerminationCode, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            if ((type & TerminationCodeType.Emergency) == TerminationCodeType.Emergency)
            {
                if (inputCode.Equals(EmergencyTerminationCode))
                {
                    return true;
                }
            }

            return false;
        }

        public void RequestTerminationCodeMessage(TerminationCodeType type)
        {
            if ((type & TerminationCodeType.Normal) == TerminationCodeType.Normal)
            {
                Console.WriteLine($"Press <{NormalTerminationCode}> to exit, else continue... ");
            }

            if ((type & TerminationCodeType.Emergency) == TerminationCodeType.Emergency)
            {
                Console.WriteLine($"Press <{EmergencyTerminationCode}> to emergency exit, else continue...");
            }
        }

        public void PrintTerminationMessage()
        {
            Console.WriteLine("Thank You");
        }
    }
}
