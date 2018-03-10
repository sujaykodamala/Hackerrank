using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class DiagonalDifference
    {
        static int diagonalDifference(int[][] a)
        {
            int d1 = 0;
            int d2 = 0;
            int m = a.GetLength(0);
            for (int i = 0; i <= m - 1; i++)
            {
                d1 += a[i][i];
            }

            for (int j = m - 1; j >= 0; j--)
            {
                for (int k = 0; k <= m - 1; k++)
                {
                    if (j + k == m - 1)
                    {
                        d2 += a[j][k];

                    }

                }
            }
            return Math.Abs(d2 - d1);
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            int result = diagonalDifference(a);
            Console.WriteLine(result);
        }
    }
}
