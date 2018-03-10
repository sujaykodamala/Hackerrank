using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class VeryBigSum
    {
        static long aVeryBigSum(int n, long[] ar)
        {
            // Complete this function
            long a = 0;
            foreach (var item in ar)
            {
                if (item >= 0 && item <= Math.Pow(10.00, 10))
                {
                    a += item;
                }
            }
            return a;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
            long result = aVeryBigSum(n, ar);
            Console.WriteLine(result);
        }
    }
}
