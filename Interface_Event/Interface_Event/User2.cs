using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Event
{
    class User2:Ievent
    {
        public A aaa = new A();
        public void Start()
        {
            Console.WriteLine("User2注册事件");
            aaa.ievent = this;


        }

        public void OnEvent()
        {
            Console.WriteLine("User2 接受到事件，开始响应...");

        }



    }
}
