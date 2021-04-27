using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Player : RunAction
    {
        public void FastRun()
        {
            Console.WriteLine("fast run");
        }

        public void Look()
        {
            //throw new NotImplementedException();
            Console.WriteLine("look");
        }

        public void Run()
        {
            //throw new NotImplementedException();
            Console.WriteLine("run");
        }

        public void Sit()
        {
            //throw new NotImplementedException();
            Console.WriteLine("sit");
        }

        public void SlowRun()
        {
            //throw new NotImplementedException();
            Console.WriteLine("slow run");
        }

        public void Walk()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Walk");
        }
    }
}
