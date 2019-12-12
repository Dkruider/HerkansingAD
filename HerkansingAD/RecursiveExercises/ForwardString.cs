using System.Collections.Generic;
using System.Linq;

namespace HerkansingAD.RecursiveExercises
{
    class ForwardString
    {
        public string Forward(List<int> list, int from)
        {
            if (from == list.Count || from > list.Count)
            {
                return "";
            }

            return list[from] + " " + Forward(list, from + 1);
        }

        public string BackwardString(List<int> list, int to)
        {
            return string.Join(" ", Forward(list, to).Split(" ").Reverse());
        }
    }
}
