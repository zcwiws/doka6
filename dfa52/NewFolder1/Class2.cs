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
        public class Subscriber
        {
            public void Subscribe(Publisher publisher)
            {
                publisher.Notify += OnNotifyReceived;
            }

            private void OnNotifyReceived()
            {
                Console.WriteLine("Событие получено в Subscriber!");
            }
        }
    }
}

