using System;
using System.Collections.Generic;
using System.Text;

namespace HerkansingAD.RecursiveExercises
{
    class Enen
    {
        public int EnenMethod(int n)
        {
            if (n <= 1) return n;

            int mod = n % 2;

            if (mod == 0) return EnenMethod(n / 2);
            return EnenMethod(n / 2) + 1;
        }
    }
}
