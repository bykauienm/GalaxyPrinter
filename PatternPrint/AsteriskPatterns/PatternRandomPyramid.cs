using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrint.AsteriskPatterns
{
    public class PatternRandomPyramid : PatternBase
    {
        public override string Print(int height)
        {
            int sortCount = height * 10;
            var asteriskList = new List<string>();
            
            for (int count = 0; count < height; count++)
            {
                var pattern = new PatternPyramid();
                asteriskList.Add(pattern.Print(count + 1));
            }

            var random = new Random();
            for(int count = 0; count < sortCount; count++)
            {
                int index1 = random.Next(height);
                int index2 = random.Next(height);
                if (index1 == index2)
                {
                    continue;
                }

                var temp = asteriskList[index1];
                asteriskList[index1] = asteriskList[index2];
                asteriskList[index2] = temp;
            }

            var builder = new StringBuilder();
            foreach (var asterisk in asteriskList)
            {
                builder.Append(asterisk);
                builder.Append("\n");
            }

            return builder.ToString();
        }
    }
}
