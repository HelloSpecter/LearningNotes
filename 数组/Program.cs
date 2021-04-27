using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2 ,3},{ 2, 3,5 } };
            //Console.WriteLine(a[0, 0]);
            //Console.WriteLine(a[0, 1]);
            //Console.WriteLine(a[1, 0]);
            //Console.WriteLine(a[1, 1]);
            //foreach(int c in a)
            //Console.WriteLine(c);
            int[,] b = a;
            Console.ReadLine();
            //行列交换
        }
    }
}
