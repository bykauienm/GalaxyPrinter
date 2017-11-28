using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum PatternType
    {
        None,
        Pyramid,
        Reverse,
        Diamond
    }

    internal class PatternPrinter
    {

        public PatternType IsValidPattern(string readString)
        {
            int retNum;
            if (int.TryParse(readString, out retNum))
            {
                switch (retNum)
                {
                    case (int)PatternType.Pyramid: return PatternType.Pyramid;
                    case (int)PatternType.Reverse: return PatternType.Reverse;
                    case (int)PatternType.Diamond: return PatternType.Diamond;
                    default: return PatternType.None;
                }
            }
            return PatternType.None;
        }

        public bool IsOutOfRange(PatternType type, int num)
        {
            if (num < 1 || num > 100)
                return true;

            if (type == PatternType.Diamond)
            {
                if ((num % 2) == 0)
                    return true;
            }

            return false;
        }

        public void PrintAsteriskPyramidReverse(int height)
        {
            StringBuilder asterisk = new StringBuilder();
            for (int i = 0; i < height; i++)
            {
                asterisk.Clear();
                for (int j = 0; j < height; j++)
                {
                    if (i > j)
                    {
                        asterisk.Append(" ");
                    }
                    else
                    {
                        asterisk.Append("*");
                    }
                }
                Console.WriteLine(asterisk);
            }
        }

        public void PrintAsteriskPyramid(int height)
        {
            StringBuilder asterisk = new StringBuilder();
            for (int i = 0; i < height; i++)
            {
                asterisk.Clear();
                for (int j = 0; j < i + 1; j++)
                {
                    asterisk.Append("*");
                }
                Console.WriteLine(asterisk);
            }
        }

        public void PrintAsteriskDiamond(int height)
        {
            int a = (height + 1) / 2;
            int b = a * 3;
            int c = a;

            StringBuilder asterisk = new StringBuilder();
            for (int i = 1; i <= height; i++)
            {
                asterisk.Clear();
                for (int j = 1; j <= height; j++)
                {
                    int x = i + j;
                    int y = Math.Abs(i - j);
                    if ((x > a) && (x < b) && (y < a))
                    {
                        asterisk.Append("*");
                    }
                    else
                    {
                        asterisk.Append(" ");
                    }
                }
                Console.WriteLine(asterisk);
            }
        }
    }
}