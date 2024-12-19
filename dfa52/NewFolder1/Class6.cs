using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67.NewFolder1
{
    using System;

    namespace EventExamples
    {
        public class MultipleSubscribers
        {
            public void RunExample()
            {
                var publisher = new PublisherWithMessage();

                var subscriber1 = new SubscriberWithMessage();
                var subscriber2 = new SubscriberWithMessage();

                subscriber1.Subscribe(publisher);
                subscriber2.Subscribe(publisher);

                publisher.TriggerEvent("Привет, подписчики!");
            }
        }
    }
}


