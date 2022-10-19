using System;
using System.Collections.Generic;

namespace DataStructure
{
    class CustomStack<T>
    {
        private int _topIndex;
        private List<T> _list;

        public CustomStack()
        {
            _topIndex = -1;
            _list = new List<T>();
        }

        public int Count => _list.Count;

        public bool IsEmpty => _list.Count == 0;

        public void Push(T item)
        {
            _list.Add(item);
            _topIndex++;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Empty");
            }

            return _list[_topIndex];
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Empty");
            }

            var top = _list[_topIndex];
            _list.Remove(top);
            _topIndex--;
            return top;
        }

        public void Clear()
        {
            _list.Clear();
            _topIndex = -1;
        }
    }
}
