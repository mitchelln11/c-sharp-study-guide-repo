using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.ObserverPattern
{
    // Unique class, not inheriting from anywhere
    class YouTubeChannel
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();
        
        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
            Console.WriteLine("{0} Subscirbed", subscriber.Name);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
            Console.WriteLine("{0} Unsubscribed", subscriber.Name);
        }

        public void Upload()
        {
            NotifySubscribers();
        }

        // Notice Private below, which is then run in a public class  above ^^ (Encapsulation)
        private void NotifySubscribers()
        {
            foreach (ISubscriber subscriber in subscribers)
            {

                subscriber.Notify(subscriber);
            }
        }
    }
}
