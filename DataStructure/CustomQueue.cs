using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class CustomQueue<T>
    {
        private readonly List<T> _items;
        public CustomQueue() => _items = new List<T>();
        public void Enqueue(T item) => _items.Add(item);
        public T Dequeue()
        {
            if (Count == 0) 
            {
                throw new Exception("Empty");
            }

            var first = _items[0];
            _items.Remove(first);
            return first;
        }
        public T Peek() => _items[0];
        public void Clear() => _items.Clear();
        public int Count => _items.Count;
    }
}
