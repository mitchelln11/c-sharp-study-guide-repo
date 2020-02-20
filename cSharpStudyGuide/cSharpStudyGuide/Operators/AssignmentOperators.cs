using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.Operators
{
    class AssignmentOperators
    {
        public double opExampleOne = 17;
        public double opExampleTwo = 4;

        // Assignment Operators

        // =
        // Assigns a variable to another value or method return value
        public static double EqualSample(double opExampleOne, double opExampleTwo) // Passing numbers as arguments/parameters
        {
            double totalSample = opExampleOne + opExampleTwo;
            return totalSample; // Returns -- 21
        }

        // +=
        // Adds a value to an existing value
        public static double PlusEqualSample(double opExampleOne, double opExampleTwo) // Passing numbers as arguments/parameters
        {
            double totalSample = 5;
            totalSample += opExampleOne; // Shorter version of totalSample = totalSample + opExampleOne
            return totalSample; // Returns -- 22
        }

        // +=
        // Subtracts a value to an existing value
        public static double SubtEqualSample(double opExampleOne, double opExampleTwo) // Passing numbers as arguments/parameters
        {
            double totalSample = 20;
            totalSample -= opExampleOne; // Shorter version of totalSample = totalSample - opExampleOne
            return totalSample; // Returns -- 3
        }

        // *=
        // Multiplies a value to an existing value
        public static double MultEqualSample(double opExampleOne, double opExampleTwo) // Passing numbers as arguments/parameters
        {
            double totalSample = 20;
            totalSample *= opExampleOne; // Shorter version of totalSample = totalSample * opExampleOne
            return totalSample; // Returns -- 340
        }

        // /=
        // Divides a value to an existing value
        public static double DivEqualSample(double opExampleOne, double opExampleTwo) // Passing numbers as arguments/parameters
        {
            double totalSample = 34;
            totalSample /= opExampleOne; // Shorter version of totalSample = totalSample * opExampleOne
            return totalSample; // Returns -- 2
        }

        // /=
        // Uses Modulus to find remainder of an existing value
        public static double ModEqualSample(double opExampleOne, double opExampleTwo) // Passing numbers as arguments/parameters
        {
            double totalSample = 36;
            totalSample %= opExampleOne; // Shorter version of totalSample = totalSample * opExampleOne
            return totalSample; // Returns -- 2
        }
    }
}
