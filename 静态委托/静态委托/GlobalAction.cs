using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态委托
{
    public  class GlobalAction
    {
        public static void test1()
        {
            Console.WriteLine("这是一个静态方法");
        }

        public void test2()
        {
            Console.WriteLine("这是一个方法");
        }
        
    }
}
