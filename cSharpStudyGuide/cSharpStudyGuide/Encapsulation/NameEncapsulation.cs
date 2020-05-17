using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.Encapsulation
{
    class NameEncapsulation
    {
        // I've been trying to find examples of how to add multiple default values, like, "Tim", "Tom", and "Tony, but I can't seem to find any
        // I think they're better suited for a single default value, like a beginning bank account amount.


        // Updated, short-hand way to set up encapsulation --  Works
        public string Name { get; set; }

        //// Old way of setting up private info and using getter/setter Properties -- This works below
        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}


        //-----------------------------------------------------------------------

        ////Assigned value from the start
        //private string name = "Teddy";

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
    }
}
