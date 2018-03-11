using System;
using System.Collections.Generic;
using System.Text;

namespace 30DaysofCode
{
    class IntroToConditionals
    {
        static void Main(String[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int O = N % 2;
            if (O == 0 && (N > 20 || N >= 2 && N <= 5))
            {
                Console.WriteLine("Not Weird");
            }
            if (O != 0)
            {
                Console.WriteLine("Weird");
            }
            if (O == 0 && (N >= 6 && N <= 20))
            {
                Console.WriteLine("Weird");
            }
        }
    }
}
