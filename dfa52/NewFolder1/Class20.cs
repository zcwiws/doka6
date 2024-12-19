using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67.NewFolder1
{
    namespace EventExamples
    {
        public class LightSubscriber
        {
            public void Subscribe(Light light)
            {
                light.StateChanged += OnStateChanged;
            }

            private void OnStateChanged(bool isOn)
            {
                Console.WriteLine($"Свет теперь {(isOn ? "включен" : "выключен")}");
            }
        }
    }
}
