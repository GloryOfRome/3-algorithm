using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1DataStructure
{
    class Array1
    {
        private int[] data;
        private int N;

        public Array1(int capacity)//当用户确定数组长度时，使用此构造函数
        {
            data = new int[capacity];
            N = 0;
        }

        public Array1() : this(10) { }//此构造函数与下面的作用一样，是一种简单写法

        //让用户访问数组信息,三个公开的属性
        public int capacity//得到长度
        {
            get { return data.Length; }
        }

        public int count//实际记录元素的数量
        {
            get { return N; }
        }

        public bool IsEmpty//判断动态数组是否为空
        {
            get { return N == 0; }
        }
        //public Array1()//当用户不确定数组长度时，使用此构造函数（多态polymorphism）
        //{
        //    data = new int[10];//避免空间浪费，开一个默认空间（10）
        //    N = 0;
        //}

    }
}
