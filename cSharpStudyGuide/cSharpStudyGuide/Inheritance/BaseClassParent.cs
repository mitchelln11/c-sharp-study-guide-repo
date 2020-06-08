using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.Inheritance
{
    // When a method or variable are going to be re-used, we create a parent/base class
    class BaseClassParent
    {
        public string brand = "Honda";

        public void honk()
        {
            Console.WriteLine("Beep Beep");
        }
    }
}
