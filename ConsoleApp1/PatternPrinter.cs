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
        Diamond,
        Diagnal,
        Horn
    }

    internal class PatternPrinter
    {

        public void PrintPattern(PatternType type, int resultNum)
        {
            if (type == PatternType.Pyramid)
            {
                PrintAsteriskPyramid(resultNum);
            }
            else if (type == PatternType.Reverse)
            {
                PrintAsteriskPyramidReverse(resultNum);
            }
            else if (type == PatternType.Diamond)
            {
                PrintAsteriskDiamond(resultNum);
            }
            else if (type == PatternType.Diagnal)
            {
                PrintAsteriskDiagnal(resultNum);
            }
            else if (type == PatternType.Horn)
            {
                PrintAsteriskHorn(resultNum);
            }
        }

        public PatternType IsValidPattern(string readString)
        {
            int retNum;
            if (int.TryParse(readString, out retNum))
            {
                switch (retNum)
                {
                    case (int)PatternType.Pyramid:
                        {
                            return PatternType.Pyramid;
                        }
                    case (int)PatternType.Reverse:
                        {
                            return PatternType.Reverse;
                        }
                    case (int)PatternType.Diamond:
                        {
                            return PatternType.Diamond;
                        }
                    case (int)PatternType.Diagnal:
                        {
                            return PatternType.Diagnal;
                        }
                    case (int)PatternType.Horn:
                        {
                            return PatternType.Horn;
                        }
                    default:
                        {
                            return PatternType.None;
                        }
                }
            }
            return PatternType.None;
        }

        public bool IsOutOfRange(PatternType type, int num)
        {
            if (num < 1 || num > 100)
            {
                return true;
            }

            if (type == PatternType.Diamond)
            {
                if ((num % 2) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void PrintAsteriskPyramidReverse(int height)
        {
            StringBuilder asterisk = new StringBuilder();
            for (int row = 0; row < height; row++)
            {
                asterisk.Clear();
                for (int column = 0; column < height; column++)
                {
                    if (row > column)
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
            for (int row = 0; row < height; row++)
            {
                asterisk.Clear();
                for (int column = 0; column < row + 1; column++)
                {
                    asterisk.Append("*");
                }
                Console.WriteLine(asterisk);
            }
        }

        public void PrintAsteriskDiamond(int height)
        {
            int conditionA = (height + 1) / 2;
            int conditionB = conditionA * 3;

            StringBuilder asterisk = new StringBuilder();
            for (int row = 1; row <= height; row++)
            {
                asterisk.Clear();
                for (int column = 1; column <= height; column++)
                {
                    int indexSum = row + column;
                    int indexDiff = Math.Abs(row - column);

                    if ((indexSum > conditionA) && (indexSum < conditionB) && (indexDiff < conditionA))
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

        public void PrintAsteriskDiagnal(int height)
        {
            StringBuilder asterisk = new StringBuilder();
            for (int row = 0; row < height; row++)
            {
                asterisk.Clear();
                for (int column = 1; column <= (height * 2) - 1; column++)
                {
                    if (column >= (height - row) && column <= (height * 2) - 1 - row)
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

        public void PrintAsteriskHorn(int height)
        {
            StringBuilder asterisk = new StringBuilder();
            for (int row = 0; row < height; row++)
            {
                asterisk.Clear();
                for (int column = 1; column <= (height * 2) - 1; column++)
                {
                    if (column >= (height - row) && column <= (height * 2) - 1 - (row * 2))
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