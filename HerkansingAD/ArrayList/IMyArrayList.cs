﻿using System;

namespace Huiswerk2
{
    public interface IMyArrayList
    {
        // Add an element to the end of the list (as long
        // as there is still capacity)
        void Add(int n);

        // Get the value from an index
        int Get(int index);

        // Set the value at a certain index
        void Set(int index, int n);

        // Returns the capacity of the list
        int Capacity();

        // Returns the size of the list
        int Size();

        // Clears the list
        void Clear();

        // Count the number of occurences in the list of a number
        int CountOccurences(int n);
        
        // Remove last value in the list
        int RemoveLast();
    }

    public class MyArrayListIndexOutOfRangeException : Exception
    {
    }
    
    public class MyArrayListFullException : Exception
    {
    }
}
