using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AsteriskPatterns
{
    public class PatternPyramid : PatternBase
    {
        public override void Print(int height)
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
    }
}
