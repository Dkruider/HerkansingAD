using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Huiswerk2
{
    public class MyArrayList : IMyArrayList
    {
        private int[] data;
        private int size;

        public MyArrayList(int capacity)
        {
            data = new int[capacity];
            size = 0;
        }

        public void Add(int n)
        {
            if (size == data.Length) throw new MyArrayListFullException();

            data[size] = n;
            size++;
        }

        public int Get(int index)
        {
            if (index < 0 || index >= size || size == 0) throw new MyArrayListIndexOutOfRangeException();

            return data[index];
        }

        public void Set(int index, int n)
        {
            if (index < 0 || index >= size || size == 0) throw new MyArrayListIndexOutOfRangeException();

            data[index] = n;
        }

        public int Capacity()
        {
            return data.Length;
        }

        public int Size()
        {
            return size;
        }

        public void Clear()
        {
            size = 0;
        }

        public int CountOccurences(int n)
        {
            int occurrences = 0;
            for (int i = 0; i < size; i++)
            {
                if (data[i].Equals(n)) occurrences++;
            }

            return occurrences;
        }

        public bool CheckValueExist(int n)
        {
            bool exist = false;

            for (int i = 0; i < size; i++)
            {
                if (!data[i].Equals(n)) continue;
                exist = true;
                break;
            }

            return exist;
        }

        public override string ToString()
        {
            int[] temp = new int[size];

            for (int i = 0; i < size; i++)
            {
                temp[i] = data[i];
            }

            return size == 0 ? "NIL" : "[" + string.Join(",", temp) + "]";
        }
    }
}
