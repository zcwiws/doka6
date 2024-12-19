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
        public class InterfaceSubscriber
        {
            public void Subscribe(INotifiable publisher)
            {
                publisher.Notify += OnNotifyReceived;
            }

            private void OnNotifyReceived(string message)
            {
                Console.WriteLine($"Сообщение через интерфейс: {message}");
            }
        }
    }

}
