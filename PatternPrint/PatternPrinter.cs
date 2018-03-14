using PatternPrint.AsteriskPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrint
{

    public class PatternPrinter
    {
        private Dictionary<string, PatternBase> PatternDictionary { get; set; }

        public PatternPrinter()
        {
            PatternDictionary = new Dictionary<string, PatternBase>();
            PatternDictionary.Add("1", new PatternPyramid());
            PatternDictionary.Add("2", new PatternReverse());
            PatternDictionary.Add("3", new PatternDiamond());
            PatternDictionary.Add("4", new PatternDiagnal());
            PatternDictionary.Add("5", new PatternHorn());
            PatternDictionary.Add("6", new PatternIncreasePyramid());
            PatternDictionary.Add("7", new PatternRightUpPyramid());
            PatternDictionary.Add("8", new PatternRandomPyramid());
            PatternDictionary.Add("9", new PatternRandomDiamond());
        }

        public PatternBase FindPattern(string select)
        {
            if (PatternDictionary.ContainsKey(select))
                return PatternDictionary[select];
            else
                return null;
        }

        public void InvaildPatternTypeMessage()
        {
            Console.Clear();
            Console.WriteLine($"Invalid pattern type 1..{PatternDictionary.Count}");
        }

        public void RequestInputTypeMessage()
        {
            string question =
                    $"How select pattern type? \n" +
                    $"1. *     2. *****   3.   *     4.    *****  5.    *****  6. *  \n" +
                    $"   **        ****       ***         *****        ****          \n" +
                    $"   ***        ***      *****       *****        ***         *  \n" +
                    $"   ****        **       ***       *****        **           ** \n" +
                    $"   *****        *        *       *****        *                \n" +
                    $"                                                            *  \n" +
                    $"                                                            ** \n" +
                    $"7. *     *      *      8.(6-Random) 9.(3-Random)           ***\n" +
                    $"         **     **     *                   *                   \n" +
                    $"                ***                       ***                  \n" +
                    $"                       *                   *                   \n" +
                    $"                       **                                      \n" +   
                    $"                       ***                 *                   \n" +   
                    $"                                                               \n" +   
                    $"                       *                   *                   \n" +
                    $"                       **                 ***                  \n" +
                    $"                                         *****                 \n" +
                    $"                                          ***                  \n" +
                    $"                                           *                   \n" +

                    $"Select type number (1 ~ {PatternDictionary.Count}) ";
            Console.WriteLine(question);
        }
    }
}