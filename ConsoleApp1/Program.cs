using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string readString = "";
            int resultNum = 0;

            while (true)
            {
                readString = "";
                resultNum = 0;

                Console.Write("How many lines? (1..100) ");
                readString = Console.ReadLine();

                bool result = Int32.TryParse(readString, out resultNum);
                if (result == false)
                {
                    Console.WriteLine("Invalid input - Range 1..100");
                    continue;
                }

                if (Program.IsOutOfRange(resultNum) == true)
                {
                    Console.WriteLine("Invalid input - Range 1..100");
                    continue;
                }

                Program.PrintAsteriskPyramid(resultNum);
                return;
            }
        }


        public static bool IsOutOfRange(int num)
        {
            if (num < 1 || num > 100)
                return true;

            return false;
        }

        public static void PrintAsteriskPyramid(int height)
        {
            for (int i = 0; i < height; i++)
            {
                string asterisk = "";
                for (int j = 0; j < i + 1; j++)
                {
                    asterisk += "*";
                }
                Console.WriteLine(asterisk);
            }
        }

    }
}
