using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 水温报警_观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("水温的初始温度是：");
            Heater heater = new Heater(Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
