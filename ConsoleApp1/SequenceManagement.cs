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
        public readonly string NORMAL_TERMINATION_CODE = "Q";
        public readonly string EMERGENCY_TERMINATION_CODE = "0";

        public bool CheckTerminationCode(string inputCode, TerminationCodeType type)
        {
            if ((type & TerminationCodeType.Normal) == TerminationCodeType.Normal)
            {
                if (inputCode.Equals(NORMAL_TERMINATION_CODE, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            if ((type & TerminationCodeType.Emergency) == TerminationCodeType.Emergency)
            {
                if (inputCode.Equals(EMERGENCY_TERMINATION_CODE))
                {
                    return true;
                }
            }

            return false;
        }

        public void ExitProgram(bool isExit)
        {
            if (isExit == true)
            {
                Environment.Exit(0);
            }
        }

        public void RequestTerminationCodeMessage(TerminationCodeType type)
        {
            if ((type & TerminationCodeType.Normal) == TerminationCodeType.Normal)
            {
                Console.WriteLine($"Press <{NORMAL_TERMINATION_CODE}> to exit, else continue... ");
            }

            if ((type & TerminationCodeType.Emergency) == TerminationCodeType.Emergency)
            {
                Console.WriteLine($"Press <{EMERGENCY_TERMINATION_CODE}> to emergency exit, else continue...");
            }
        }

        public void PrintTerminationMessage()
        {
            Console.WriteLine("Thank You");
        }
    }
}
