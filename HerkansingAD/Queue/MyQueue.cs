using System;
using System.Collections.Generic;

namespace Huiswerk2
{
    public class MyQueue<T> : IMyQueue<T>
    {
        private readonly List<T> _list = new List<T>();
        private int _front, _count, _back = -1;

        public bool IsEmpty()
        {
            return _front > _back;
        }

        public void Enqueue(T data)
        {
            _list.Add(data);

            _back++;
            _count++;
        }

        public T GetFront()
        {
            if (IsEmpty()) throw new MyQueueEmptyException();

            return _list[_front];
        }

        public T GetBack()
        {
            if (IsEmpty()) throw new MyQueueEmptyException();

            return _list[_back];
        }

        public T Dequeue()
        {
            if (IsEmpty()) throw new MyQueueEmptyException();

            T first = _list[_front];

            _list[_front] = default(T);

            _front++;
            _count--;

            return first;
        }

        public void Clear()
        {
            _list.Clear();

            _front = 0;
            _back = -1;
        }

        public bool Contains(T data)
        {
            for (int i = _front; i < _back; i++)
            {
                if (_list[i].Equals(data)) return true;
            }

            return false;
        }

        public int Count()
        {
            return _count;
        }

        public override string ToString()
        {
            string printString = "";

            for (int i = _front; i <= _back; i++)
            {
                printString += _list[i];
                if (i != _back) printString += ",";
            }

            return "[" + printString + "]";
        }
    }
}