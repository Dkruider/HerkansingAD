using System;
using System.Collections.Generic;
using System.Text;

namespace HerkansingAD.RecursiveExercises
{
    class OmEnOm
    {
        public int OmEnOmMethod(int n)
        {
            if (n < 0) throw new OmEnOmNegativeValueException();
            if (n == 0) return 0;
            if (n == 1) return 1;

            return n + OmEnOmMethod(n - 2);
        }
    }

    public class OmEnOmNegativeValueException : Exception
    {
    }
}
