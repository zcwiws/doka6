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
        public class SubscriberWithCustomEventArgs
        {
            public void Subscribe(PublisherWithCustomEventArgs publisher)
            {
                publisher.Notify += OnNotifyReceived;
            }

            private void OnNotifyReceived(object sender, CustomEventArgs e)
            {
                Console.WriteLine($"Получено сообщение: {e.Message}, Значение: {e.Value}");
            }
        }
    }
}