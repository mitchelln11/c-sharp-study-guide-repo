using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.Operators
{
    class RegOperators
    {
        public double opExampleOne = 17;
        public double opExampleTwo = 4;
        // +
        //REGULAR ADDITION when dealing with numbers : Also concatenating when dealing with strings
        public static double AddSample(double opExampleOne, double opExampleTwo) // Passing numbers as arguments/parameters
        {
            double totalSample = opExampleOne + opExampleTwo; // Actual addition
            return totalSample; // Returning the result   -- 21
        }

        // -
        // REGULAR SUBTRACTION
        public static double SubSample(double opExampleOne, double opExampleTwo)
        {
            double totalSample = opExampleOne - opExampleTwo;// Actual subtraction
            return totalSample; // Returning the result   -- 13
        }

        // *
        // REGULAR MULTIPLICATION
        public static double MultSample(double opExampleOne, double opExampleTwo)
        {
            double totalSample = opExampleOne * opExampleTwo; // Actual multiplication
            return totalSample; // Returning the result   -- 68
        }

        // /
        //REGULAR DIVISION
        public static double DivSample(double opExampleOne, double opExampleTwo)
        {
            double totalSample = opExampleOne / opExampleTwo; // Actual multiplication
            return totalSample; // Returning the result   -- 4.25
        }

        // %
        //MODULUS, or largest remaining whole integer
        public static double ModulSample(double opExampleOne, double opExampleTwo)
        {
            double totalSample = opExampleOne % opExampleTwo; // Actual multiplication
            return totalSample; // Returning the result   -- 1
        }

        // ++
        // INCREMENT number by 1
        public static double IncrSample(double opExampleOne)
        {
            return opExampleOne++; // Returning the result   -- 18
        }

        // --
        // DECREMENT number by 1
        public static double DecrSample(double opExampleOne)
        {
            return opExampleOne--; // Returning the result   -- 16
        }
    }
}
