using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpStudyGuide.Tests;
using cSharpStudyGuide.Encapsulation;


namespace cSharpStudyGuide
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////// DIFFERENT FOLDER EXAMPLE BELOW /////////////////////
            // Must add using statement with namespace AND folder name
            //Vendor v = new Vendor();
            //v.buySoda();



            ////////////////// NameEncapsulation EXAMPLES BELOW /////////////////////

            NameEncapsulation person = new NameEncapsulation();
            person.Name = "Timmy";
            Console.WriteLine(person.Name);
            Console.ReadLine();

            //-----------------------------------------------------------------------

            //// You can add multiples this way
            //NameEncapsulation person = new NameEncapsulation();
            //person.Name = "Timmy";

            //NameEncapsulation person2 = new NameEncapsulation();
            //person2.Name = "Tony";

            //Console.WriteLine(person.Name); // Must call the variable, or you will just get cSharpStudyGuide, Encapsulation, NameEncapsulation
            //Console.WriteLine(person2.Name);
            //Console.ReadLine();

            //-----------------------------------------------------------------------

            // If something already exists, or was declared in the private variable, you can access it this way.
            //NameEncapsulation person = new NameEncapsulation();

            //Console.WriteLine(person.Name);
            //Console.ReadLine();
        }
    }
}
