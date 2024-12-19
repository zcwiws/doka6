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
        public delegate void NotifyDelegate(string message);

        public class PublisherWithDelegate
        {
            public event NotifyDelegate Notify;

            public void TriggerEvent(string message)
            {
                Notify?.Invoke(message);
            }
        }
    }
}