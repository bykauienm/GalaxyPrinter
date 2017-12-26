using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrint.AsteriskPatterns
{
    public class PatternReverse : PatternBase
    {
        public override string Print(int height)
        {
            StringBuilder asterisk = new StringBuilder();
            for (int row = 0; row < height; row++)
            {
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
                asterisk.Append("\n");
            }
            Console.WriteLine(asterisk);
            return asterisk.ToString();
        }
    }
}
