using System;

namespace homework_6
{
    class Program
    {
        static void p136ex42()
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < 8; i++)
            {
                int score = int.Parse(Console.ReadLine());
                if (score > max)
                {
                    max = score;
                    index = i;
                }
            }
            System.Console.WriteLine($"The top score was {max} in spot {index}");
        }
        static void p136ex43()
        {
            double height, max, min;
            height = double.Parse(System.Console.ReadLine());
            max = height;
            min = height;
            min = 0;
            for (int i = 0; i < 9; i++)
            {
                height = double.Parse(Console.ReadLine());
                if (height > max)
                {
                    max = height;
                }
                if (height < min)
                {
                    min = height;
                }
            }
            System.Console.WriteLine(max);
            System.Console.WriteLine(min);
        }
        static void p136ex44()
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > 0 && num < min)
                {
                    min = num;
                }
                else
                {
                    if (num < 0 && num > max)
                    {
                        max = num;
                    }
                }
            }
            System.Console.WriteLine($"Smallest positive: {min} \n Largest negative: {max}");
        }
        static void p137ex45()
        {
            int min, max;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int min_larger = Math.Max(a, b);
            int max_smaller = Math.Min(a, b);
            for (int i = 1; i < 100; i++)
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                min = Math.Max(a, b);
                max = Math.Min(a, b);
                if (min < min_larger)
                {
                    min_larger = min;
                }
                if (max > max_smaller)
                {
                    max_smaller = max;
                }
            }
        }
        static void p137ex46()
        {
            System.Console.WriteLine("Racer count");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Speed");
            int speed = int.Parse(Console.ReadLine());
            int first = speed;
            int second = speed;
            for (int i = 0; i < n - 1; i++)
            {
                System.Console.WriteLine("Speed");
                speed = int.Parse(Console.ReadLine());
                if (speed > first)
                {
                    second = first;
                    first = speed;
                }
            }
            System.Console.WriteLine(first);
            System.Console.WriteLine(second);
        }
        static void Main(string[] args)
        {
            p137ex46();
        }
    }
}
