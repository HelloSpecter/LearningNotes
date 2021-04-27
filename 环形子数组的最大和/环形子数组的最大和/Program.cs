using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 环形子数组的最大和
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[4] { 9, -4, -7, 9 };
            int[] dp1 = new int[A.Length];

            int max = A[0];
            dp1[0] = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                dp1[i] = Math.Max(dp1[i - 1] + A[i], A[i]);
            }
            max = dp1.Max();


            if (A.Length > 2)
            {
                int sum = A.Sum();
                int min;
                int temp = 0;
                int[] cur = new int[A.Length - 2];
                int[] dp2 = new int[A.Length - 2];
                for (int i = 1; i < A.Length - 1; i++)
                {
                    cur[temp++] = A[i];

                }

                dp2[0] = cur[0];
                for (int i = 1; i < cur.Length; i++)
                {
                    dp2[i] = Math.Min(dp2[i - 1] + cur[i], cur[i]);
                }
                min = dp2.Min();
                max = Math.Max(dp1.Max(), sum - min);
            }




            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
