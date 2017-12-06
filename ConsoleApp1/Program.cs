using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            PatternPrinter printer = new PatternPrinter();
            string readString = String.Empty;
            int resultNum = 0;

            while (true)
            {
                readString = String.Empty;
                resultNum = 0;

                printer.RequestInputTypeMessage();
                readString = Console.ReadLine();
                var pattern = printer.FindPattern(readString);
                if (pattern == null)
                {
                    printer.InvaildPatternTypeMessage();
                    continue;
                }

                pattern.RequestInputMessage();
                readString = Console.ReadLine();
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

                Console.Write("press <Q> to exit, else continue... ");
                if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    return;
                }
                Console.Clear();
            }
        }
    }
}
