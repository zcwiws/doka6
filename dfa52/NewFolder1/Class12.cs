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
        public class CustomEventArgs : EventArgs
        {
            public string Message { get; set; }
            public int Value { get; set; }
        }

        public class PublisherWithCustomEventArgs
        {
            public event EventHandler<CustomEventArgs> Notify;

            public void TriggerEvent(string message, int value)
            {
                Notify?.Invoke(this, new CustomEventArgs { Message = message, Value = value });
            }
        }
    }
}
