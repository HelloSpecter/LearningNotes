using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托方式_水温报警_观察者模式
{
    class Alarm
    {
        public Alarm(Heater heater)
        {
            heater.mytemplete += Alert;
        }
        private void Alert(int temp)
        {
            Console.WriteLine("水已经开了_闹铃启动");
        }
    }
}
