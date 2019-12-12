using System;
using System.Collections.Generic;
using System.Text;

namespace HerkansingAD.BijlesAD
{
    class LinkedListWithoutHeaderNode
    {
        private int size;
        private Node _start;

        public LinkedListWithoutHeaderNode()
        {
            size = 0;
        }

        public void AddFirst(int x)
        {
            size++;

            if (_start == null)
            {
                _start = new Node { data = x };
                return;
            }

            Node oldFirst = _start;
            _start = new Node { data = x, next = oldFirst };
        }

        public void AddLast(int x)
        {
            size++;

            Node current = _start;
            Node parent = _start;

            while (current != null)
            {
                parent = current;
                current = current.next;
            }

            parent.next = new Node { data = x };
        }

        public void Add(int index, int x)
        {
            if (index > size || index < 0) throw new IndexOutOfRangeException("Index was outside the bounds of the Linked list.");

            Node newNode = new Node { data = x };

            if (_start == null)
            {
                if (index != 0) return;
                _start = newNode;
            }

            if (index == 0)
            {
                newNode.next = _start;
                _start = newNode;
            }
            else
            {
                Node current = _start;
                Node previous = _start;

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

            Node current = _start;

            for (int i = 0; i < size; i++)
            {
                printString += current.data;
                if (i < size - 1) printString += ",";
                current = current.next;
            }

            return size == 0 ? "NIL" : "[" + printString.TrimEnd() + "]";
        }
    }

    public class Node
    {
        public int data;
        public Node next;
    }
}
