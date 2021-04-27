using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装箱拆箱_逐字字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = @"c:\windows";
            //string str2 = "c:\windows";
            string str3 = "c:\\windows";
            Console.WriteLine(str1+"\n"+str3);
            Console.ReadLine();
            int a = 8;
            object bb = a;
            string c =(string)bb;//会报错
            //string cc = (string)a;
            Console.WriteLine(c+"\n"+bb+"\n"+a);
        }
    }
}
