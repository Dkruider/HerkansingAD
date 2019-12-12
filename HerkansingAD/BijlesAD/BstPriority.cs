using System;
using System.Collections.Generic;
using System.Text;

namespace HerkansingAD.BijlesAD
{
    public class BstPriority<T>
    {
        public static int DEFAULT_CAPACITY = 100;
        public int LastIndex;
        public int[] Array;

        public BstPriority()
        {
            LastIndex = 0;
            Array = new int[DEFAULT_CAPACITY];

            for (int i = 1; i < DEFAULT_CAPACITY; i++)
            {
                Array[i] = -1;
            }
        }

        public void Add(int x)
        {
            if (Array[1].Equals(-1))
            {
                Array[1] = x;
                return;
            }

            int i = 1;

            while (!Array[i].Equals(-1))
            {
                int compare = x.CompareTo(Array[i]);
                switch (compare)
                {
                    case -1:
                        i *= 2;
                        break;
                    case 1:
                        i = i * 2 + 1;
                        break;
                }
            }

            LastIndex = i;
            Array[i] = x;
        }

        public bool Contains(int x)
        {
            for (int i = 1; i < LastIndex; i++)
            {
                if (Array[i].Equals(x)) return true;
            }

            return false;
        }

        public int Find(int x)
        {
            int index = -1;

            for (int i = 1; i <= LastIndex; i++)
            {
                if (Array[i].Equals(x))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public int FindLastIndex()
        {
            int index = -1;

            for (int i = 1; i < DEFAULT_CAPACITY; i++)
            {
                if (Array[i] != -1)
                {
                    index = i;
                }
            }

            return index;
        }

        public int Remove(int x)
        {
            int index = Find(x);
            int removedValue = Array[index];

            Array[index] = -1;

            // set last index
            LastIndex = FindLastIndex();

            return removedValue;
        }

        public override string ToString()
        {
            string printString = "";

            for (int i = 1; i <= LastIndex; i++)
            {
                printString += $"index: {i} value: {Array[i]}\n";
            }

            return printString;
        }
    }
}
