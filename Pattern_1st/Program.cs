using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_1st
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i < 5; i++)
            {
                string asterisk = "";
                for(int j = 0; j < i+1; j++)
                {
                    asterisk += "*";
                }
                Console.WriteLine(asterisk);
            }
        }
    }
}
