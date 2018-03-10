using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank
{
    class DataTypes
    {

        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "Hackerrank";
            int j = Convert.ToInt32(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
            string x = Convert.ToString(Console.ReadLine());
            // Read and save an integer, double, and String to your variables.

            // Print the sum of both integer variables on a new line.

            // Print the sum of the double variables on a new line.


            // Concatenate and print the String variables on a new line
            Console.WriteLine((i + j).ToString());
            Console.WriteLine((d + e).ToString("F1"));
            Console.WriteLine(s + x);
            // The 's' variable above should be printed first.

        }
    }
}
