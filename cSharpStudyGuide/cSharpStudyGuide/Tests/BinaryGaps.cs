using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.Tests
{
    class BinaryGaps
    {
       public int BinaryGapSolution(int N) 
        {
            int[] numArray = new int[32];
            int i, j;

            for (i = 0; N > 0; i++)
            {
                
                numArray[i] = N % 2;
                N /= 2;
            }

            for (j = i - 1; j>= 0; j--)
            {
                Console.WriteLine(numArray[j]);
            }
            Console.WriteLine(N);

            //Console.WriteLine(N.ToString());
            return N;
            //if(N > 0) { 
            //    Console.WriteLine(N);
            //    return N;
            //} 
            //   else
            //{
            //   return 0;
            //}
        }

    }
}
