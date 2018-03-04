using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyPrinter
{
    public class SequenceManagement
    {
        public static string TerminationCode { get; private set; } = "0";

        public bool CheckTerminationCode(string inputCode)
        {
            if (inputCode.Equals(TerminationCode))
            {
                return true;
            }

            return false;
        }

        public void RequestTerminationCodeMessage()
        {
            Console.WriteLine($"Press <{TerminationCode}> to exit, else continue... ");
        }

        public void PrintTerminationMessage()
        {
            Console.Clear();
            Console.WriteLine("Thank You");
        }
    }
}
