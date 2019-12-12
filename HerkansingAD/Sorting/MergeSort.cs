using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HerkansingAD.Sorting
{
    public class MergeSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            List<int> sortedList = SortRecursive(list);
            list.Clear();
            list.AddRange(sortedList);
        }

        public static List<int> SortRecursive(List<int> list)
        {
            if (list.Count <= 1) return list;

            const int left = 0;
            int right = list.Count;
            int center = (left + right) / 2;

            List<int> leftList = list.GetRange(0, center);
            List<int> rightList = list.GetRange(center, right - center);

            leftList = SortRecursive(leftList);
            rightList = SortRecursive(rightList);

            return Merge(leftList, rightList);
        }

        private static List<int> Merge(IReadOnlyList<int> leftList, IReadOnlyList<int> rightList)
        {
            int leftIndex = 0, rightIndex = 0;
            LinkedList<int> returnList = new LinkedList<int>();

            while (leftIndex < leftList.Count || rightIndex < rightList.Count)
            {
                int? leftItem = null;
                if (leftIndex < leftList.Count)
                {
                    leftItem = leftList[leftIndex];
                }

                int? rightItem = null;
                if (rightIndex < rightList.Count)
                {
                    rightItem = rightList[rightIndex];
                }

                if (leftItem != null && (rightItem == null || leftItem <= rightItem))
                {
                    returnList.AddLast((int)leftItem);
                    leftIndex++;
                }
                else if (rightItem != null)
                {
                    returnList.AddLast((int)rightItem);
                    rightIndex++;
                }
            }

            return returnList.ToList();
        }

    }
}
