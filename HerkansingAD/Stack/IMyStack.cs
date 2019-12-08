using System;

namespace Huiswerk2
{
    public interface IMyStack<T>
    {
        bool IsEmpty();
        void Push(T data);
        T Top();
        T Pop();
    }

    public class MyStackEmptyException : Exception
    {
    }

}
