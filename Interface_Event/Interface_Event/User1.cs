using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Event
{
    class User1 : Ievent
    {
        public  A aa = new A();
        public  void Start()
        {
            Console.WriteLine("User1注册事件");
            aa.ievent = this;

        }
        
        

        public void OnEvent()
        {
            Console.WriteLine("User1 接受到事件，开始响应...");
        }
    }
}
