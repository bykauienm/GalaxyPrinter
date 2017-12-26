using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrint.AsteriskPatterns
{
    public class PatternDiamond : PatternBase
    {
        public override string Print(int height)
        {
            int conditionA = (height + 1) / 2;
            int conditionB = conditionA * 3;

            StringBuilder asterisk = new StringBuilder();
            for (int row = 1; row <= height; row++)
            {
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
                asterisk.Append("\n");
            }
            Console.WriteLine(asterisk);
            return asterisk.ToString();
        }

        public override bool IsOutOfRange(int number)
        {
            if (base.IsOutOfRange(number))
                return true;

            if ((number % 2) == 0)
                return true;
            else
                return false;
        }

        public override void RequestInputMessage()
        {
            Console.Clear();
            Console.Write("How many lines? (1..100), only odd number  ");
        }
        public override void InvalidInputRangeMessage()
        {
            Console.Clear();
            Console.Write("Invalid input - Range 1..100, only odd number");
        }
    }
}
