using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 斐波那契数列
{
    class Fibonacci
    {
        int[] fibonacci;
        int GetNumber(int month)
        {
            if (month < 2 && month > 0)
            {
                fibonacci[month] = 1;
                
            }
            else if (month <= 0)
            {
                fibonacci[month] = 0;
            }
            else
	        {
                fibonacci[month] = GetNumber(month - 1) + GetNumber(month - 2);
            }
            return fibonacci[month];

        }
        public int[] GetNumber(bool bl,int num)
        {
            fibonacci = new int[num+1];
            GetNumber(num);
            return fibonacci;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci m_fibonacci = new Fibonacci();
            int num;
            for (int i = 0; ; i++)
            {
                Console.WriteLine("输入一个月份");
                num=int.Parse(Console.ReadLine());
            int[] m_squence = m_fibonacci.GetNumber(true,num);
            foreach (var item in m_squence)
            {
                Console.Write(item+" ");
            }
                Console.WriteLine("\n");
            }
        }
    }
}
