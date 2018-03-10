using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class CompareTriplets
    {
        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            // Complete this function
            int[] a = { a0, a1, a2 };
            int[] b = { b0, b1, b2 };
            int i = 0;
            int j = 0;
            for (int k = 0; k < a.Length; k++)
            {
                if (a[k] > b[k])
                {
                    i++;
                }
                else if (a[k] < b[k])
                {
                    j++;
                }
            }
            int[] score = { i, j };
            return score;
        }

        static void Main(String[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int[] result = solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(String.Join(" ", result));


        }
    }
}
