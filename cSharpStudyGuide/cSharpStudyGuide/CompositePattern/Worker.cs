using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.CompositePattern
{
    public class Worker : IEmployee
    {
        // Private accessibility level
        private string name;
        private string title;
        private int happinessPercent;
        public Worker(string name, string title, int happinessPercent)
        {
            this.name = name;
            this.title = title;
            this.happinessPercent = happinessPercent;
        }
        public void DisplayStatus()
        {
            Console.WriteLine("{0} {1} shows happiness level of {2} percent", title, name, happinessPercent);
        }
    }
}
