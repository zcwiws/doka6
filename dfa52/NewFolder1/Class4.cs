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
        public class SubscriberWithMessage
        {
            public void Subscribe(PublisherWithMessage publisher)
            {
                publisher.Notify += OnNotifyReceived;
            }

            private void OnNotifyReceived(string message)
            {
                Console.WriteLine($"Получено сообщение: {message}");
            }
        }
    }

}