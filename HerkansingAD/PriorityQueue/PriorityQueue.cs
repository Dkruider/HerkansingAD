using System;

namespace Huiswerk5
{
    public class PriorityQueue<T> : IPriorityQueue<T>
        where T : IComparable<T>
    {
        public static int DEFAULT_CAPACITY = 100;
        public int size;   // Number of elements in heap
        public T[] array;  // The heap array

        //----------------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------------
        public PriorityQueue()
        {
            size = 0;
            array = new T[DEFAULT_CAPACITY];
        }

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------
        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            size = 0;
        }

        public void ResizeQueue()
        {
            Array.Resize(ref array, array.Length * 2);
        }

        public void Add(T x)
        {
            if (size + 1 >= array.Length) ResizeQueue();

            size++;
            array[size] = x;

            if (size > 1) PercolateUp(size);
        }

        // Removes the smallest item in the priority queue
        public T Remove()
        {
            if (size == 0) throw new PriorityQueueEmptyException();

            T temp = array[1];

            array[1] = array[size];
            size--;

            PercolateDown(1);

            return temp;
        }

        public void Swap(int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public void PercolateUp(int node)
        {
            int nodeIndex = node;
            int parentIndex = node / 2;
            int compare = array[nodeIndex].CompareTo(array[parentIndex]);

            while (compare == -1)
            {
                Swap(parentIndex, nodeIndex);

                nodeIndex = parentIndex;
                parentIndex = nodeIndex / 2;

                compare = array[nodeIndex].CompareTo(array[parentIndex]);
            }
        }

        public void PercolateDown(int node)
        {
            int parentIndex = node;
            int childIndex1 = parentIndex * 2;
            int childIndex2 = parentIndex * 2 + 1;

            while (parentIndex < size)
            {
                int compareChild1 = (parentIndex * 2 <= size) ? array[parentIndex].CompareTo(array[childIndex1]) : -1;
                int compareChild2 = (parentIndex * 2 + 1 <= size) ? array[parentIndex].CompareTo(array[childIndex2]) : -1;

                // if parent is smaller than both children, exit while loop
                if (compareChild1 == -1 && compareChild2 == -1) break;

                // when both children are smaller, search for smallest child
                if (compareChild1 == 1 && compareChild2 == 1)
                {
                    int compare = array[childIndex1].CompareTo(array[childIndex2]);

                    if (compare == -1)
                    {
                        Swap(parentIndex, childIndex1);
                        parentIndex = childIndex1;
                    }
                    else
                    {
                        Swap(parentIndex, childIndex2);
                        parentIndex = childIndex2;
                    }
                }

                // only child1 is smaller than the parent
                if (compareChild1 == 1 && compareChild2 != 1)
                {
                    Swap(parentIndex, childIndex1);
                    parentIndex = childIndex1;
                }

                // only child2 is smaller than the parent
                if (compareChild2 == 1 && compareChild1 != 1)
                {
                    Swap(parentIndex, childIndex2);
                    parentIndex = childIndex2;
                }

                childIndex1 = parentIndex * 2;
                childIndex2 = parentIndex * 2 + 1;
            }
        }

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public void AddFreely(T x)
        {
            if (size + 1 >= array.Length) ResizeQueue();

            size++;
            array[size] = x;
        }

        public void BuildHeap()
        {
            if (size <= 1) return;

            for (int i = size; i > 0; i--)
            {
                PercolateDown(i);
            }
        }

        public override string ToString()
        {
            string printString = "";

            for (int i = 1; i <= size; i++)
            {
                printString += array[i] + " ";
            }

            return printString.TrimEnd();
        }
    }
}
