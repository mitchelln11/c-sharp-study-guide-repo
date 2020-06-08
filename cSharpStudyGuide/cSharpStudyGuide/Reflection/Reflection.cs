using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.Reflection
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int ZipCode { get; set; }

        public void Print()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public void Move(int newZipCode)
        {
            ZipCode = newZipCode;
            Console.WriteLine($"{FirstName} {LastName} moved to a new {newZipCode}");
        }
    }
}