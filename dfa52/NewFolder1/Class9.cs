using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67.NewFolder1 { 


namespace EventExamples
{
    public class PublisherWithParameters
    {
        public event Action<int, string> Notify;

        public void TriggerEvent(int number, string message)
        {
            Notify?.Invoke(number, message);
        }
    }
}
}