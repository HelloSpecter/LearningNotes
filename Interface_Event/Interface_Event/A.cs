using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Event
{
        public  interface Ievent
        {
            void OnEvent();
        }
    class A
    {

        public Ievent ievent;

        public void StartEvent()
        {
            Console.WriteLine("触发接口事件ievent.OnEvent():");
            ievent.OnEvent();
        }


    }
}
