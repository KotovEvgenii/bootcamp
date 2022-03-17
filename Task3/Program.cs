using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (var item in str)
            {
                if (!dic.ContainsKey(item))
                    dic[item] = 1;
                else
                    dic[item] = dic[item] + 1;
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"'{item.Key}'{item.Value}");
            }

            Console.ReadKey();
        }
    }
}
