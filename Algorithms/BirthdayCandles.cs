using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class BirthdayCandles
    {
        static int birthdayCakeCandles(int n, int[] ar)
        {
            // Complete this function
            Int32 a = ar.Max();
            int count = 0;
            int candleNo = 0;
            for (int i = 0; i < n; i++)
            {
                if (ar[i] == a)
                {
                    count++;

                }
            }
            return count;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
        }
    }
}
