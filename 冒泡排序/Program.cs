using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 7, 9, 23, 14, 67, 54, 10, 2, 0, 5, 0, 7, 8 };
            int temp = 0;
            for (int i = 0; i < num.Length-1; i++)
            {
                for (int j = 0; j < num.Length-i-1; j++)
                {
                    if (num[j]>=num[j+1])
                    {
                         temp=num[j + 1];
                        num[j + 1] = num[j];
                        num[j] = temp;

                    }
                }
            }
            foreach (var n in num)
            {
                Console.Write(n+" ");
            }
            Console.ReadLine();
        }
    }
}
