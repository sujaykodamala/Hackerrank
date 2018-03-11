using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyDaysofCode
{
    class LetsReview
    {
        static void Main(String[] args)
        {
            int T = Convert.ToInt16(Console.ReadLine());
            List<Char> list1 = new List<Char>();
            List<Char> list2 = new List<Char>();
            for (int i = 0; i < T; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (j % 2 == 0)
                    {

                        list1.Add(s[j]);
                    }
                    else
                    {
                        list2.Add(s[j]);
                    }
                }

                Console.WriteLine(new String(list1.ToArray()) + " " + new String(list2.ToArray()));
                list1.Clear();
                list2.Clear();
            }
        }
    }
}
