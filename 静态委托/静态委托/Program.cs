using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态委托
{
    class Program
    {
        public delegate void TestMethod();
        static void Main(string[] args)
        {
            TestMethod testMethod1 = GlobalAction.test1;

            GlobalAction globalAction = new GlobalAction();
            TestMethod testMethod2 = globalAction.test2;


            testMethod1();
            testMethod2();
            Console.ReadKey();
        }
    }
}
