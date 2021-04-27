using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 ="aaaaa", num2 = "bbbbb";
            Swap.swap<string >(ref num1, ref num2);
            Console.WriteLine(num1+"\n"+num2);
            Console.ReadLine();
        }
    }
}
