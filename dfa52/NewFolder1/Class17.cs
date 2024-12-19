using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67.ewFolder1
{
    using System;
    using System.Collections.Generic;

    namespace EventExamples
    {
        public class CollectionWithEvent<T>
        {
            private List<T> items = new List<T>();

            public event Action<T> ItemAdded;

            public void AddItem(T item)
            {
                items.Add(item);
                ItemAdded?.Invoke(item);
            }
        }
    }
}