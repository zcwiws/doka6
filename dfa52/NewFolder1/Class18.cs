using ConsoleApp67.ewFolder1.EventExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67.NewFolder1
{
    namespace EventExamples
    {
        public class CollectionSubscriber
        {
            public void Subscribe<T>(CollectionWithEvent<T> collection)
            {
                collection.ItemAdded += OnItemAdded;
            }

            private void OnItemAdded<T>(T item)
            {
                Console.WriteLine($"Элемент добавлен: {item}");
            }
        }
    }
}
