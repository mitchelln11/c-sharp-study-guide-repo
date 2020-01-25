using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.ObserverPattern
{
    // example of Interface Segregation "I" in "SOLID"
    // There is a variable and a method, both of which MUST be used in the classes that inherit from the ISubscriber Interface "see Moderator class for details"
    public interface ISubscriber
    {
        string Name { get; set; }
        void Notify(ISubscriber subscriber);
    }
}
