using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class MinMaxSum
    {
        static void miniMaxSum(int[] arr)
        {
            // Complete this function
            int size = arr.Length;
            int tempVar = 0;
            Int64 count = 0;
            List<Int64> a = new List<Int64>();
            for (size = 0; size <= arr.Length - 1; size++)
            {
                tempVar = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                    count += arr[i];
                }
                a.Add(count);
                arr[arr.Length - 1] = tempVar;
                count = 0;
            }
            Int64[] b = a.ToArray();
            Console.WriteLine(b.Min() + " " + b.Max());
        }

        static void Main(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            miniMaxSum(arr);
        }
    }
}
