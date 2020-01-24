using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.ObserverPattern
{
    public class Moderator : ISubscriber
    {
        private string name;

        // Required Variable from interface
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Unique to Moderator class
        public Moderator(string name)
        {
            this.name = name;
        }

        // Required Method from interface that comes from ISubscriber 
        public void Notify(ISubscriber subscriber)
        {
            Console.Write("Moderator {0} needs to review new video!\n", subscriber.Name);
        }
    }
}
