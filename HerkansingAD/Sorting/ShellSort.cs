using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HerkansingAD.Sorting
{
    public class ShellSort : Sorter
    {
        private static LinkedList<int> CalculateIntervals(int listCount)
        {
            if (listCount <= 1) return new LinkedList<int>(new[] { 1 });

            LinkedList<int> returnList = CalculateIntervals((int)(listCount / 2.2));
            returnList.AddFirst(listCount);

            return returnList;
        }

        public override void Sort(List<int> list)
        {
            int[] intervals = CalculateIntervals((int)(list.Count / 2.2)).ToArray();

            foreach (int interval in intervals)
            {
                for (int currentIndex = interval; currentIndex < list.Count; currentIndex++)
                {
                    int reverseIndex;
                    int currentValue = list[currentIndex];

                    for (reverseIndex = currentIndex; reverseIndex >= interval && list[reverseIndex - interval] > currentValue; reverseIndex -= interval)
                    {
                        SwapValues(list, reverseIndex, reverseIndex - interval);
                    }

                }
            }
        }

        private static string ListToString(IEnumerable<int> list)
        {
            return string.Join(" ", list);
        }

        private static void SwapValues<T>(IList<T> source, int index1, int index2)
        {
            T temp = source[index1];
            source[index1] = source[index2];
            source[index2] = temp;
        }
    }
}
