using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число [0-10] для вывода последовательности: ");
            int num = 0;
            bool isGoodConvert = int.TryParse(Console.ReadLine(), out num);
            int reverce = 1;
            if (isGoodConvert = true && num >= 0 && num < 10)
            {
                for (int i = 1; i < num * 2; i++)
                {
                    if (i > num - 1)
                    {
                        Console.Write(reverce + " ");
                        reverce--;
                        continue;
                    }
                    Console.Write(reverce + " ");
                    reverce++;

                }
            }

            if (isGoodConvert = false)
                Console.WriteLine("Не удалось преобразовать в число");
            if (num < 0 && num >= 10)
                Console.WriteLine("Число должно быть от 0 до 10");
            Console.ReadKey();
        }
    }
}
