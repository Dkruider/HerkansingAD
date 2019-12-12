using System;
using System.Collections.Generic;
using System.Text;

namespace HerkansingAD.RecursiveExercises
{
    public class Factorial
    {
        public long FacRecursive(int n)
        {
            if (n <= 1) return 1;

            return n * FacRecursive(n - 1);
        }

        public long FacIterative(int n)
        {
            long value = 1;

            for (int i = 1; i <= n; i++)
            {
                value *= i;
            }

            return value;
        }
    }
}
