using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace cSharpStudyGuide.OutParameter
{
    class OutParam
    {
        public void OutAverage(out double inputSum, out double count, out double averageNumber)
        {
            inputSum = 188;
            count = 23;
            averageNumber = inputSum / count;
            Console.WriteLine(averageNumber); // Rounds off the number to a whole???
        }
    }
}
