using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class PlusMinus
    {
        static void plusMinus(int[] arr)
        {
            // Complete this function
            decimal positive = 0.0000000m;
            decimal negative = 0.0000000m;
            decimal zero = 0.0000000m;
            foreach (var item in arr)
            {
                if (item > 0)
                {
                    positive++;
                }
                else if (item == 0)
                {
                    zero++;
                }
                else if (item < 0)
                {
                    negative++;
                }
            }
            int l = arr.Length;
            decimal d = Convert.ToDecimal(positive / l);
            string s = string.Format("{0: .######}", d.ToString());
            Console.WriteLine(s);
            decimal d1 = Convert.ToDecimal(negative / l);
            string s1 = string.Format("{0: .######}", ((float)d1).ToString());
            Console.WriteLine(s1);
            decimal d2 = Convert.ToDecimal(zero / l);
            string s2 = string.Format("{0: .######}", ((float)d2).ToString());
            Console.WriteLine(s2);
            // float negativeLength = negative/l;
            // float zeroLength = zero/l;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            plusMinus(arr);
        }
    }
}
