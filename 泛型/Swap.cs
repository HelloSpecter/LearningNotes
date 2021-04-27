using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    class Swap
    {
        public static void swap<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Swap completely!");
        }
    }
}
