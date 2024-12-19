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
        public class PublisherWithEventHandler
        {
            public event EventHandler Notify;

            public void TriggerEvent()
            {
                Notify?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}





