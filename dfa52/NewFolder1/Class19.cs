using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67.NewFolder1
{
    namespace EventExamples
    {
        public class Light
        {
            private bool isOn;

            public event Action<bool> StateChanged;

            public void Toggle()
            {
                isOn = !isOn;
                StateChanged?.Invoke(isOn);
            }
        }
    }


}
