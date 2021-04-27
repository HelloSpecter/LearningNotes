using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托方式_水温报警_观察者模式
{
    class Heater
    {
        private int Temperature;
        public delegate void Templete(int temp);
        public Templete mytemplete;
        public  Heater(int number)
        {
            if (number>100)
            {
                Console.WriteLine("初始化温度输入错误！");
            }
            else
                Temperature = number;
        
        }
        public void HeatOneTem()
        {
                Console.WriteLine("现在温度是：   "+Temperature++);
                if (Temperature>=100)
                {
                Temperature = 100;
                    mytemplete(Temperature);

                }
            
        }
    }
}
