using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrint.AsteriskPatterns
{
    public class PatternIncreasePyramid : PatternBase
    {
        public override string Print(int height)
        {
            var builder = new StringBuilder();
            for (int count = 0; count < height; count++)
            {
                var pattern = new PatternPyramid();
                builder.Append(pattern.Print(count + 1));
                builder.Append("\n");
            }

            return builder.ToString();
        }
    }
}
