using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 水温报警_观察者模式
{
    class Alarm
    {
        public static void Updata(int temperature)
        {

            if (temperature==100)
            {
                Console.WriteLine("------------响铃报警----------");
            }
            
        }
    }
}
