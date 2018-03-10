using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank
{
    class _2DArrays
    {
        static List<int> HourGlassCount = new List<int>();

        static void GetMatrix(int a, int[][] arr)
        {
            for (int i = 0; i <= 3; i++)
            {
                HourGlassCount.Add(GetCount(a, i, arr));
            }

        }

        static int GetCount(int c, int d, int[][] arr)
        {
            int count = 0;
            count += arr[c][d] + arr[c][d + 1] + arr[c][d + 2];
            count += arr[c + 1][d + 1];
            count += arr[c + 2][d] + arr[c + 2][d + 1] + arr[c + 2][d + 2];
            return count;

        }

        static void Main(String[] args)
        {
            int[][] arr = new int[6][];

            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
            for (int i = 0; i <= 3; i++)
            {

                GetMatrix(i, arr);

            }
            Console.Write(HourGlassCount.ToArray().Max());
        }

    }
}
