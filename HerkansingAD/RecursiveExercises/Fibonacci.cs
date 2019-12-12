using System;
using System.Collections.Generic;
using System.Text;

namespace HerkansingAD.RecursiveExercises
{
    class Fibonacci
    {
        public long calls = 0;

        public long FibonacciRecursive(int n)
        {
            calls++;

            if (n <= 1) return n;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        public long FibonacciIterative(int n)
        {
            long previous = 0;
            long current = 1;
            calls = 0;

            for (int i = 0; i < n; i++)
            {
                long old = current;

                current += previous;
                previous = old;

                calls++;
            }

            return previous;
        }

    }
}
