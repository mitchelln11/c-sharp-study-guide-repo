using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.Suffixes
{
    class SuffixEx
    {
        //// Standard way to declare variables
        //// Most contain a suffix at the end of the argument value or prefix at beginning
        //byte myByte = 0B0110; // Prefix of 0b, zeroB
        //sbyte mySbyte = -0B0110; // Prefix of -0B, -zeroB
        //short myShort = (short)1; // No suffix, so casting is used (short)
        //ushort myUshort = (ushort)1; // No suffix,so casting is used (ushort)

        //// Whole Numbers
        //int myInt = 1; // No suffix, default whole number
        //uint myUint = (uint)1; // No suffix,so casting is used (uint)
        //long myLong = 1L; // Suffix of L
        //ulong myUlong = 1UL; // Suffix of UL

        //// Decimal Numbers
        //float myFloat = 1.1F;
        //double myDouble = 1.1; // No suffix, default decimal number
        //decimal myDecimal = 1.1M;

        //// Boolean
        //bool myBool = true; // No prefix/suffix, not needed

        //// Characters
        //char myChar = 'a'; // With characters, you must use the single quote (apostrophy), something weird with characater type only
        //string myString = "Hello World";


        public void PreSuffix()
        {
            var myByte = 0B0110;
            var mySbyte = -0B0110;
            var myShort = (short)1;
            var myUshort = (ushort)1;

            // Whole Numbers
            var myInt = 1;
            var myUint = (uint)1;
            var myLong = 1L;
            var myUlong = 1UL;

            // Decimal Numbers
            var myFloat = 1.1F;
            var myDouble = 1.1;
            var myDecimal = 1.1M;
        }
    }
}
