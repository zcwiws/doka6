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
        public interface INotifiable
        {
            event Action<string> Notify;
            void TriggerEvent(string message);
        }
    }
}