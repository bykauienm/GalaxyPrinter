using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternPrint;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            SequenceManagement sequence = new SequenceManagement();
            PatternPrinter printer = new PatternPrinter();
            string readString = String.Empty;
            int resultNum = 0;

            while (true)
            {
                readString = String.Empty;
                resultNum = 0;

                printer.RequestInputTypeMessage();
                sequence.RequestTerminationCodeMessage();
                readString = Console.ReadLine();
                if (sequence.CheckTerminationCode(readString))
                {
                    sequence.PrintTerminationMessage();
                    return;
                }                             
                    
                var pattern = printer.FindPattern(readString);
                if (pattern == null)
                {
                    printer.InvaildPatternTypeMessage();
                    continue;
                }

                pattern.RequestInputMessage();
                sequence.RequestTerminationCodeMessage();
                readString = Console.ReadLine();
                if (sequence.CheckTerminationCode(readString))
                {
                    sequence.PrintTerminationMessage();
                    return;
                }

                if (Int32.TryParse(readString, out resultNum) == false)
                {
                    pattern.InvalidInputRangeMessage();
                    continue;
                }

                if (pattern.IsOutOfRange(resultNum))
                {
                    pattern.InvalidInputRangeMessage();
                    continue;
                }

                Console.Clear();
                var asterisk = pattern.Print(resultNum);
                Console.WriteLine(asterisk);

                sequence.RequestTerminationCodeMessage();
                readString = Console.ReadLine();
                if (sequence.CheckTerminationCode(readString))
                {
                    sequence.PrintTerminationMessage();
                    return;
                }

                Console.Clear();
            }
        }
    }
}
