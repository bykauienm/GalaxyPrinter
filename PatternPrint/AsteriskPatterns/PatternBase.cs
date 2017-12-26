using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrint.AsteriskPatterns
{
    public abstract class PatternBase
    {
        public abstract string Print(int height);
        public virtual bool IsOutOfRange(int number)
        {
            if ((number < 1) || (number > 100))
                return true;
            else
                return false;
        }
        public virtual void RequestInputMessage()
        {
            Console.Clear();
            Console.Write($"How many lines? (1..100)  ");
        }
        public virtual void InvalidInputRangeMessage()
        {
            Console.Clear();
            Console.Write("Invalid input - Range 1..100");
        }
    }
}
