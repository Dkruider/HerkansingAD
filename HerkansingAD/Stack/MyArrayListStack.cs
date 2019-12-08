using System;

namespace Huiswerk2
{
    public class MyArrayListStack<T> : IMyStack<T>
    {
        private readonly MyArrayList _myArrayList = new MyArrayList(100);

        public bool IsEmpty()
        {
            return _myArrayList.Size() == 0;
        }

        public void Push(T data)
        {
            _myArrayList.Add(Convert.ToInt32(data));
        }

        public T Top()
        {
            if (IsEmpty()) throw new MyStackEmptyException();

            int index = _myArrayList.Size();

            T value = (T)Convert.ChangeType(_myArrayList.Get(index - 1), typeof(T));

            return value;
        }

        public T Pop()
        {
            if (IsEmpty()) throw new MyStackEmptyException();

            T value = (T)Convert.ChangeType(_myArrayList.RemoveLast(), typeof(T));

            return value;
        }

        public override string ToString()
        {
            return _myArrayList.ToString();
        }
    }
}