using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank
{
    class DictionariesAndMaps
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            Dictionary<string, Int32> PhoneBook = new Dictionary<string, Int32>();
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                string name = values[0];
                int num = Convert.ToInt32(values[1]);
                PhoneBook.Add(name, num);
            }
            for (int j = n + 1; j > n; j++)
            {
                string s = Console.ReadLine();
                if (s == string.Empty)
                {
                    break;
                }
                else
                {
                    if (PhoneBook.ContainsKey(s))
                    {
                        Console.WriteLine(s + "=" + PhoneBook[s].ToString());
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                    }

                }
            }
        }
    }
}
