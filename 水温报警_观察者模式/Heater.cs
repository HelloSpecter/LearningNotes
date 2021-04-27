using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 水温报警_观察者模式
{
    class Heater
    {
        private int temperature = 0;
        //public delegate void MyNotify()
        //{

        //};
        //MyNotify myNotify =new MyNotify();
        public Heater(int number)
        {
            if (number>=100)
            {
                Console.WriteLine("初始温度输入错误!");
            }
            else
            {
                for (int i = 0; i < 100; i++)
                {
                    temperature = number + i;
                    if (temperature>100)
                    {
                        temperature = 100;
                    }
                    Notify();
                }
            }
            
        }
        public void Notify()
        {
            Screen.Updata(this.temperature);
            Alarm.Updata(this.temperature);
        }
    }
}
