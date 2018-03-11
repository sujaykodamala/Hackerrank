using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyDaysofCode
{
    class Operators
    {
        static void Main(String[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());
            double tax = Convert.ToDouble(meal_cost * tax_percent / 100);
            double tip = Convert.ToDouble(meal_cost * tip_percent / 100);
            int total = Convert.ToInt32(meal_cost + tax + tip);
            Console.WriteLine("The total meal cost is " + total.ToString() + " dollars.");
        }
    }
}
