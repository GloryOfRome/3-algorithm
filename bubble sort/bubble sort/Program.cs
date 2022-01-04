using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 3, 5, 2, 1, 0 };
            BobbleSort.Sort(a);
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
