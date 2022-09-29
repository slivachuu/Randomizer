using System;

namespace Randomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================\nRandomizer v2.0\nby slivachuu\n================");
            int repeat_mode;
            Console.WriteLine("Выберите режим: \n1. Одинарный режим\n2. Цикличный режим");
            Console.Write("> ");
            repeat_mode = Convert.ToInt32(Console.ReadLine());
            if (repeat_mode == 1)
            {
                int min, max, output;
                Console.Write("Введите минимальное число: ");
                min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите максимальное число: ");
                max = Convert.ToInt32(Console.ReadLine());
                var random = new Random();
                output = random.Next(minValue: min, maxValue: max);
                Console.WriteLine("Рандомное число: " + output);
            } 
            else if (repeat_mode == 2)
            {
                int repeat, min, max, output;
                Console.Write("Введите кол-во циклов: ");
                repeat = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите минимальное число: ");
                min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите максимальное число: ");
                max = Convert.ToInt32(Console.ReadLine());
                var random = new Random();
                for (int i = 1; i <= repeat; i++)
                {
                    output = random.Next(minValue: min, maxValue: max);
                    Console.WriteLine(i + ". Рандомное число: " + output);
                }
            }
            Console.ReadKey();
        }
    }
}