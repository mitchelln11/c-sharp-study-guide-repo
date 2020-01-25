using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.CompositePattern
{
    // Classes inheriting must use the DisplayStatus() as this is an interface "Interface Segregation" -- "I" in "SOLID"
    public interface IEmployee
    {
        void DisplayStatus();
    }
}
