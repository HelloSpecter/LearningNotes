using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    interface BaseAction
    {
        void Sit();
        void Run();
        void Walk();
        void Look();

    }
    interface RunAction:BaseAction
    {
        void FastRun();
        void SlowRun();

    }
}
