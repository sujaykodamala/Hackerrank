using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class StairCase
    {
        static void staircase(int n)
        {
            // Complete this function
            string s = "#";

            AppendStrings(s, n);


        }
        static void AppendStrings(string s1, int n)
        {
            string s2 = "";

            for (int i = n; i > 0; i--)
            {
                s2 += s1;
                Console.WriteLine(s2.PadLeft(n));
            }

        }
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            staircase(n);
        }
    }
}
