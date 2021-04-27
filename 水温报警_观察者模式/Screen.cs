using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 水温报警_观察者模式
{
    class Screen
    {
        public static void Updata(int temperature)
        {
            Console.WriteLine("现在温度是：    " + temperature);
            if (temperature >= 90 && temperature < 100)
            {
                Console.WriteLine("注意！水快要开了！");
            }
            if (temperature == 100)
            {
                Console.WriteLine("水开了，请尽快关闭电源！");
            }
        }
    }
}
