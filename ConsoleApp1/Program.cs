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
                sequence.RequestTerminationCodeMessage(TerminationCodeType.Emergency);
                readString = Console.ReadLine();
                if (sequence.CheckTerminationCode(readString, TerminationCodeType.Emergency))
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
                sequence.RequestTerminationCodeMessage(TerminationCodeType.Emergency);
                readString = Console.ReadLine();
                if (sequence.CheckTerminationCode(readString, TerminationCodeType.Emergency))
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
                
                pattern.Print(resultNum);

                sequence.RequestTerminationCodeMessage(TerminationCodeType.Normal | TerminationCodeType.Emergency);
                readString = Console.ReadLine();
                if (sequence.CheckTerminationCode(readString, TerminationCodeType.Normal | TerminationCodeType.Emergency))
                {
                    sequence.PrintTerminationMessage();
                    return;
                }

                Console.Clear();
            }
        }
    }
}
