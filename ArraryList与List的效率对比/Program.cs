using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraryList与List的效率对比
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch aa = new Stopwatch();
            //Stopwatch.GetTimestamp();
            aa.Start();
            ArrayList myarrayList = new ArrayList();
            for (int i = 0; i < 1000000; i++)
            {
                myarrayList.Add(i);
            }
            aa.Stop();
            Console.WriteLine(aa.ElapsedMilliseconds);

            //List<int>[] list = new List<int>[100000];
            //for (int i = 0; i < list.Length; i++)
            //{
            //    list[i].Add(2);
            //}
         

            Console.ReadLine();
        }
    }
}
