using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank
{
    class Loops
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n.ToString() + " x " + i.ToString() + " = " + (n * i).ToString());
            }
        }
    }
}
