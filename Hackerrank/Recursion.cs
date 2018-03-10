using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank
{
    class Recursion
    {
    static int factorial(int n)
    {
        // Complete this function
        int num = 1;
        for (int i = 1; i <= n; i++)
        {
            num = num * i;
        }
        return num;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int result = factorial(n);

        Console.WriteLine(result);

    }
}
}
