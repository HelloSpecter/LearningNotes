using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clone_copy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ori = new  int[3]{ 1,2,3};
            int[] clone;
            int[] copy;
            clone = (int[])ori.Clone();
            //ori.CopyTo(copy, 0);//copyTo需要初始化
            copy = new int[3];
            ori.CopyTo(copy, 0);
            ori[2] = -1;

            Console.WriteLine("ori:");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("[" + ori[i] + "]");
            }

            Console.WriteLine("\nclone:");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("["+clone[i] + "]");
            }

            Console.WriteLine("\ncopy:");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("[" + copy[i] + "]");
            }

            Console.ReadKey();
        }
    }
}
