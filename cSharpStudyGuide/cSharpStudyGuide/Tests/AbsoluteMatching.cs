using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.Tests
{
    class AbsoluteMatching
    {
        public int valA = 5;

        // When using absolute value, it always switches a negative number to a positive.

        public void AbsChecker()
        {
            if ( -Math.Abs(valA) == -valA )
            {
                Console.WriteLine("True");
                Console.WriteLine(-Math.Abs(valA)); // The way to possibly check for a negative equivalent of a positive number
            }
            else
            {
                Console.WriteLine("False");
                Console.WriteLine(-Math.Abs(valA));
            }
        }
    }
}
