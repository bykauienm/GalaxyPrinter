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
                    "1. *     2. *****   3.   *     4.    *****  5.    *****\n" +
                    "   **        ****       ***         *****        ****  \n" +
                    "   ***        ***      *****       *****        ***    \n" +
                    "   ****        **       ***       *****        **      \n" +
                    "   *****        *        *       *****        *        \n" +
                    " Select type number (1 ~ 5) ";
                Console.Write(question);
                readString = Console.ReadLine();
                PatternType type = printer.IsValidPattern(readString);
                if (type == PatternType.None)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid pattern - select 1 ~ 5");
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

                printer.PrintPattern(type, resultNum);

                Console.Write("press <Q> to exit, else continue... ");
                if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    Console.Clear();
                    return;
                }

                Console.Clear();
            }
        }
    }
}
