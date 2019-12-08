using System;

namespace Huiswerk2
{
    public interface IMyQueue<T>
    {
        bool IsEmpty();
        void Enqueue(T data);
        T GetFront();
        T GetBack();
        T Dequeue();
        void Clear();
        bool Contains(T data);
        int Count();
    }

    public class MyQueueEmptyException : Exception
    {
    }
}