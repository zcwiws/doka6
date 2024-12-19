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
        public class InterfacePublisher : INotifiable
        {
            public event Action<string> Notify;

            public void TriggerEvent(string message)
            {
                Notify?.Invoke(message);
            }
        }
    }
}
