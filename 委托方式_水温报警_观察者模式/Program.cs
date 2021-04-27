using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托方式_水温报警_观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入现在的水温:  ");
            Heater heater1 = new Heater(Convert.ToInt32(Console.ReadLine()));
            Screen screen = new Screen(heater1);
            Alarm alarm = new Alarm(heater1);
            for (int i = 0; i < 100; i++)
            {
                heater1.HeatOneTem();
            }
            Console.ReadLine();

        }
    }
}
