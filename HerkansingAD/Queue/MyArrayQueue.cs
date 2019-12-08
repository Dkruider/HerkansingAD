using System;
using System.Collections.Generic;
using System.Text;

namespace Huiswerk2.Ex5Queue
{
    class MyArrayQueue<T> : IMyQueue<T>
    {
        private static readonly int _capacity = 100;
        private readonly T[] _array = new T[_capacity];
        private int _front, _count, _back = -1;

        public bool IsEmpty()
        {
            return _front > _back;
        }

        public void Enqueue(T data)
        {
            if (_back + 1 >= _capacity) Clear();

            _back++;
            _count++;

            _array[_back] = data;
        }

        public T GetFront()
        {
            if (IsEmpty()) throw new MyQueueEmptyException();
            return _array[_front];
        }

        public T GetBack()
        {
            if (IsEmpty()) throw new MyQueueEmptyException();
            return _array[_back];
        }

        public T Dequeue()
        {
            if (IsEmpty()) throw new MyQueueEmptyException();

            T front = GetFront();

            _front++;
            _count--;

            return front;
        }

        public void Clear()
        {
            _front = 0;
            _back = -1;
        }

        public bool Contains(T data)
        {
            for (int i = _front; i < _back; i++)
            {
                if (_array[i].Equals(data)) return true;
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
                printString += _array[i];
                if (i != _back) printString += ",";
            }

            return "[" + printString + "]";
        }
    }
}
