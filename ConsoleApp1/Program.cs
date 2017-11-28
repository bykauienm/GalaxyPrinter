using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
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

                string question =
                    "How select pattern type?            \n" +
                    "1. *         2. *****      3.   *  \n" +
                    "   **            ****          *** \n" +
                    "   ***            ***         *****\n" +
                    "   ****            **          *** \n" +
                    "   *****            *           *  \n" +
                    " Select type number (1 ~ 3) : ";
                Console.Write(question);
                readString = Console.ReadLine();
                PatternType type = printer.IsValidPattern(readString);
                if (type == (int)PatternType.None)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid pattern - select 1 ~ 3");
                    continue;
                }

                Console.WriteLine($"[type: {type.ToString()}], Diamond only odd number");
                Console.Write($"How many lines? (1..100) ");
                readString = Console.ReadLine();
                bool result = Int32.TryParse(readString, out resultNum);
                if (result == false)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input - Range 1..100");
                    continue;
                }

                if (printer.IsOutOfRange(type, resultNum) == true)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input - Range 1..100");
                    continue;
                }

                if (type == PatternType.Pyramid)
                {
                    printer.PrintAsteriskPyramid(resultNum);
                }
                else if (type == PatternType.Reverse)
                {
                    printer.PrintAsteriskPyramidReverse(resultNum);
                }
                else if (type == PatternType.Diamond)
                {
                    printer.PrintAsteriskDiamond(resultNum);
                }

                return;
            }
        }
    }
}
