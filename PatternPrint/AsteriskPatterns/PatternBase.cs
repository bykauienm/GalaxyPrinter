using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrint.AsteriskPatterns
{
    public enum Range
    {
        Min = 1,
        Max = 100
    }

    public abstract class PatternBase
    {
        public abstract string Print(int height);
        public virtual bool IsOutOfRange(int number)
        {
            if ((number < (int)Range.Min) || (number > (int)Range.Max))
                return true;
            else
                return false;
        }
        public virtual void RequestInputMessage()
        {
            Console.Clear();
            Console.WriteLine($"How many lines? ({(int)Range.Min}..{(int)Range.Max})  ");
        }
        public virtual void InvalidInputRangeMessage()
        {
            Console.Clear();
            Console.WriteLine($"Invalid input - Range {(int)Range.Min}..{(int)Range.Max}");
        }
    }
}
