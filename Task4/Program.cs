using System;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[] { 1, 2, 5, 6, 7, 8 };
            List<int> list = new List<int>();
            int xPrev;
            list.Add(mas[mas.Length - 1]);
            xPrev = mas[mas.Length - 1];
            for (int i = mas.Length - 2; i >= 1; i--)
            {
                if (mas[i] > xPrev || mas[i] < mas[i - 1])
                    continue;

                xPrev = mas[i];
                list.Add(mas[i]);
            }
            if (mas[0] <= xPrev)
                list.Add(mas[0]);

            list.Reverse();
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
