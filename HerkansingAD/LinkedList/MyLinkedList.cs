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
            if (index > size || index < 0) throw new MyLinkedListIndexOutOfRangeException();

            MyNode<T> newNode = new MyNode<T> { data = data };

            if (header == null)
            {
                if (index != 0) return;
                header = newNode;
            }

            if (index == 0)
            {
                newNode.next = header;
                header = newNode;
            }
            else
            {
                MyNode<T> current = header;
                MyNode<T> previous = header;

                for (int i = 0; i < index; i++)
                {
                    previous = current;
                    current = current.next;
                }

                newNode.next = current;
                previous.next = newNode;
            }

            size++;
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