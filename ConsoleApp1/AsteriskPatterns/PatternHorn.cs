using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AsteriskPatterns
{
    public class PatternHorn : PatternBase
    {
        public override void Print(int height)
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
