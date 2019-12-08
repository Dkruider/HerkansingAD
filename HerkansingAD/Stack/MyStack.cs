
namespace Huiswerk2
{
    public class MyStack<T> : IMyStack<T>
    {
        private readonly MyLinkedList<T> _myLinkedList = new MyLinkedList<T>();

        public bool IsEmpty()
        {
            return _myLinkedList.Size() == 0;
        }

        public T Pop()
        {
            if (IsEmpty()) throw new MyStackEmptyException();

            T first = _myLinkedList.GetFirst();
            _myLinkedList.RemoveFirst();

            return first;
        }

        public void Push(T data)
        {
            _myLinkedList.AddFirst(data);
        }

        public T Top()
        {
            if (IsEmpty()) throw new MyStackEmptyException();

            return _myLinkedList.GetFirst();
        }

        public override string ToString()
        {
            return _myLinkedList.ToString();
        }
    }
}
