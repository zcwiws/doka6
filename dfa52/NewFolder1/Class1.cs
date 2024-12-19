using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp67.NewFolder1 { 


namespace EventExamples
{
    public class Publisher
    {
        public event Action Notify;

        public void TriggerEvent()
        {
            Notify?.Invoke();
        }
    }
}
}

