using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67.NewFolder1
{
    using System;
    using System.Timers;

    namespace EventExamples
    {
        public class TimerWithEvent
        {
            private Timer timer;

            public event Action Tick;

            public TimerWithEvent(int interval)
            {
                timer = new Timer(interval);
                timer.Elapsed += (s, e) => Tick?.Invoke();
            }

            public void Start() => timer.Start();
            public void Stop() => timer.Stop();
        }
    }
}
