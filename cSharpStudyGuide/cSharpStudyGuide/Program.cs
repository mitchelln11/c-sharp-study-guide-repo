using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpStudyGuide.Tests;


namespace cSharpStudyGuide
{
    class Program
    {
        static void Main(string[] args)
        {
            // Must add using statement with namespace AND folder name
            Vendor v = new Vendor();
            v.buySoda();
        }
    }
}
