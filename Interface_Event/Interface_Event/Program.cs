using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            User1 user1 = new User1();
            User2 user2 = new User2();
            user1.Start();
            user2.Start();

            user1.aa.StartEvent();
            user2.aaa.StartEvent();
            Console.ReadKey();

        }
    }
}
