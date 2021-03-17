using System;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Answer("Введите первое число:");
            //Console.WriteLine("Число 1: {0}", a);
            //Console.WriteLine($"Число 1: {a}");
            int b = Answer("Введите второе число:");
            int c = Answer("Введите третье число:");
            int max = a;

            if (b >= a && b >= c)
            {
                max = b;
            }
            else if (c >= a && c >= b)
            {
                max = c;
            }

            Console.WriteLine("Максимальное из чисел: " + Convert.ToString(max));

            switch (max % 2)
            {
                case 0:
                    Console.WriteLine("Чётное");
                    break;
                case 1:
                    Console.WriteLine("Нечётное");
                    break;
            }
            Console.WriteLine(max < 100 ? "<100" : ">100");
            Console.ReadLine();

            int Answer (string str) 
            {
                Console.WriteLine(str);
                if (!int.TryParse(Console.ReadLine(), out int answer))
                {
                    Console.WriteLine("Ошибка! Только целые числа! (Введённое значение будет считаться как 'ноль')");
                }
                return answer;
            }
        }
    }
}
