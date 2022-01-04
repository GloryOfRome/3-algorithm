using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    class BobbleSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                ///通过循环最大的数字已经到数组的最后面
                ///-i，因为不需要对已经排好序的元素再次进行比较
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
        }

        public static void Swap(int[]arr,int i,int j)
        {
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;

        }

    }
}
