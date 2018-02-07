using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrint.AsteriskPatterns
{
    public class PatternRightUpPyramid : PatternBase
    {
        public override string Print(int height)
        {
            List<StringBuilder> asterisks = new List<StringBuilder>();
            StringBuilder gap = new StringBuilder();
            for (int index = 0; index < height; index++)
            {
                asterisks.Add(new StringBuilder());
                gap.Append(" ");
            }
            gap.Append("  ");

            for (int count = 0; count < height; count++)
            {
                for (int row = 0; row < height; row++)
                {
                    for (int column = 0; column <= count; column++)
                    {
                        if ((column <= row) && (row <= count))
                            asterisks[row].Append("*");
                        else
                            asterisks[row].Append(" ");
                    }
                    asterisks[row].Append(gap.ToString());
                }
            }

            StringBuilder retAsterisk = new StringBuilder();
            foreach (var builder in asterisks)
            {
                builder.Append("\n");
                retAsterisk.Append(builder.ToString());
            }

            return retAsterisk.ToString();    
        }
    }
}
