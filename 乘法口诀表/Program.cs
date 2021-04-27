using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 乘法口诀表
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("{0}*{1}={2} ", j, i, j * i);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
            //float[] c = new float[2];
            //Console.WriteLine(c[0]+"\n"+c[1]);
            //Console.ReadLine();
        }
    }
}
