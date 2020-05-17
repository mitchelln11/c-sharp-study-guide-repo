using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.Tests
{
    class Vendor
    {
        // Has to be public in order to pass to the program, or anywhere else, to run it.
        public void buySoda()
        {
            double quarter = 0.25;
            double dime = 0.10;
            double nickel = 0.05;
            double penny = 0.01;

            double sodaPrice = 3.75;

            Console.WriteLine(quarter);
            Console.ReadLine();
        }
    }
}
