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
        public class SubscriberWithUnsubscribe
        {
            private PublisherWithMessage _publisher;

            public void Subscribe(PublisherWithMessage publisher)
            {
                _publisher = publisher;
                _publisher.Notify += OnNotifyReceived;
            }

            public void Unsubscribe()
            {
                if (_publisher != null)
                {
                    _publisher.Notify -= OnNotifyReceived;
                    Console.WriteLine("Отписка выполнена.");
                }
            }

            private void OnNotifyReceived(string message)
            {
                Console.WriteLine($"Получено сообщение: {message}");
            }
        }
    }
}