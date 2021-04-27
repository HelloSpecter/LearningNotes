using System;
using System.Linq;

namespace 运算符_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "bot", "apple", "apricot" };
            int minimalLength = words
              .Where(w => w.StartsWith("a"))
              .Min(w => w.Length);
            Console.WriteLine(minimalLength);   // output: 5

            int[] numbers = { 4, 7, 10 };
            int product = numbers.Aggregate(1, (interim, next) => interim * next);
            Console.WriteLine(product);   // output: 280
            Console.ReadKey();
        }
    }
}
