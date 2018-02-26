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
            var asterisks = GenerateAsteriskList(height);
            SortList(asterisks);
            return CombineAsterisk(asterisks);            
        }

        public List<string> GenerateAsteriskList(int height)
        {
            var asteriskList = new List<string>();

            for (int count = 0; count < height; count++)
            {
                var pattern = new PatternPyramid();
                asteriskList.Add(pattern.Print(count + 1));
            }
            return asteriskList;
        }

        public void SortList(List<string> list)
        {
            int height = list.Count;
            int sortCount = height * 10;
            var random = new Random();
            for (int count = 0; count < sortCount; count++)
            {
                int index1 = random.Next(height);
                int index2 = random.Next(height);
                if (index1 == index2)
                {
                    continue;
                }

                var temp = list[index1];
                list[index1] = list[index2];
                list[index2] = temp;
            }
        }

        public string CombineAsterisk(List<string> list)
        {
            var builder = new StringBuilder();
            foreach (var asterisk in list)
            {
                builder.Append(asterisk);
                builder.Append("\n");
            }

            return builder.ToString();
        }
    }
}
