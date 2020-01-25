using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.CompositePattern
{
    public class Supervisor : IEmployee
    {
        // Accessibility level set to Private as they only belong to this specific class
        private string name;
        private string title;
        private int happinessPercent;
        private List<IEmployee> employees = new List<IEmployee>();
        
        // Passes in private variables from above ^^ as parameters
        public Supervisor(string name, string title, int happinessPercent)
        {
            this.name = name;
            this.title = title;
            this.happinessPercent = happinessPercent;
        }
        public void DisplayStatus()
        {
            Console.WriteLine("{0} {1} shows happiness level of {2} percent", title, name, happinessPercent);

            // Able to do this as we already instantiated a new list above 
            foreach (IEmployee employee in employees) // Make sure you match the data type, this case, a data type of IEmployee
            {
                employee.DisplayStatus();
            }
        }

        // Passing in List of employees from new instance above
        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }
    }
}
