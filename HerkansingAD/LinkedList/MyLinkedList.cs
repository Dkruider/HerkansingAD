using System;
using System.ComponentModel;

namespace Huiswerk2
{
    public class MyLinkedList<T> : IMyLinkedList<T>
    {
        public MyNode<T> header;
        private int size;

        public MyLinkedList()
        {
            header = null;
            size = 0;
        }

        public void AddFirst(T data)
        {
            size++;

            if (header == null)
            {
                header = new MyNode<T> { data = data };
                return;
            }

            MyNode<T> temp = header;
            header = new MyNode<T> { data = data, next = temp };
        }

        public T GetFirst()
        {
            if (header == null) throw new MyLinkedListEmptyException();

            return header.data;
        }

        public void RemoveFirst()
        {
            if (size == 0) throw new MyLinkedListEmptyException();

            size--;

            header = header.next;
        }

        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            header = null;
            size = 0;
        }

        public void Insert(int index, T data)
        {
            if (index > size || index < 0)
            {
                throw new MyLinkedListIndexOutOfRangeException();
            }

            MyNode<T> prevNode = header;

            //    Move to the 'previous' node, so index - 1
            int currentIndex = 0;
            while (currentIndex < index - 1)
            {
                prevNode = prevNode.next;

                currentIndex++;
            }

            //    Determine 'next' node, either the previous node's next node or the header.
            MyNode<T> nextNode = index != 0 ? prevNode.next : header;
            MyNode<T> newNode = new MyNode<T> { data = data, next = nextNode };

            //    Increment size
            size++;

            //    Place node back onto the linked list
            if (nextNode == header)
            {
                header = newNode;
                return;
            }

            prevNode.next = newNode;

        }

        public override string ToString()
        {
            string printString = "";

            MyNode<T> current = header;

            for (int i = 0; i < size; i++)
            {
                printString += current.data;
                if (i < size - 1) printString += ",";
                current = current.next;
            }

            return size == 0 ? "NIL" : "[" + printString.TrimEnd() + "]";
        }
    }
}