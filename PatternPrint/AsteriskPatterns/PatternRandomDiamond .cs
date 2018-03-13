using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrint.AsteriskPatterns
{
    public class PatternRandomDiamond : PatternDiamond
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

            for (int count = 0; count < height; count += 2)
            {
                asteriskList.Add(PrintDiamondGroup(count + 1, height));
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

        public string PrintDiamondGroup(int height, int numberOfGroup)
        {
            int conditionA = (height + 1) / 2;
            int conditionB = conditionA * 3;

            StringBuilder asterisk = new StringBuilder();
            for (int row = 1; row <= height; row++)
            {

                for (int count = 1; count <= ((numberOfGroup - height) / 2); count++)
                {
                    asterisk.Append(" ");
                }
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

            return asterisk.ToString();
        }

    }
}