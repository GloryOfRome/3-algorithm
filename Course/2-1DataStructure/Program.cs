using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _2_1DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];//新建数组

            //对数组赋值
            Console.WriteLine("this is array");
            for (int i = 0; i < 10; i++)//如果将10改为20，者会产生越界错误
            {
                arr[i] = i;//赋值
                Console.Write(arr[i] + " ");//打印
            }

            Console.WriteLine();

            Console.WriteLine("this is ArrayList");
            ArrayList a = new ArrayList(10);
            for(int i = 0; i < 15; i++)//即使小于15，仍然不会越界，这就是动态数组的优势
            {
                a.Add(i);
                Console.Write(a[i] + " ");

            }

            Console.WriteLine();

            Console.WriteLine("this is List");
            List<int> l = new List<int>(10);
            for (int i = 0; i < 20; i++)//即使小于20，仍然不会越界，这就是动态数组的优势
            {
                l.Add(i);
                Console.Write(l[i] + " ");
            }
            Console.Read();

        }
    }
}
