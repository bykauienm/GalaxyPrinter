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
                    "How select pattern type?            \n" +
                    "1. *     2. *****   3.   *     4.    *****  5.    *****\n" +
                    "   **        ****       ***         *****        ****  \n" +
                    "   ***        ***      *****       *****        ***    \n" +
                    "   ****        **       ***       *****        **      \n" +
                    "   *****        *        *       *****        *        \n" +
                    " Select type number (1 ~ 5) ";
            Console.Write(question);
        }
    }
}