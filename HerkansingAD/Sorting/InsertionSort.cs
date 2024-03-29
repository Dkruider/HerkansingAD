﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HerkansingAD.Sorting
{
    class InsertionSort : Sorter
    {
        public override void Sort(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                int key = list[i];
                int j = i - 1;

                while (j >= 0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = key;
            }
        }
    }
}
