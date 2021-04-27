using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举enum
{
    class Program
    {
        public enum GameState
        {
            Start,End,Pause
        }
        static void Main(string[] args)
        {
            string seasonStr0 = Enum.GetName(typeof(GameState), 3);//越界则没有值
            string seasonStr1 = ((GameState)3).ToString();//越界则返回数字值
            Console.WriteLine("Str0:   "+seasonStr0);
            Console.WriteLine("Str1:   " + seasonStr1);
            Console.ReadLine();

        }
    }
}
