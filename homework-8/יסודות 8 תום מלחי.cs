using System;

namespace homework_8
{
    class Program
    {
        static void firstLetter()
        {
            char firstInName = Console.ReadLine()[0];
            string s = Console.ReadLine();
            for (int i = 1; i <= s.Length; i++)
            {
                if (s[i] == firstInName)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        static void addToNum()
        {
            System.Console.WriteLine("Enter any number");
            string num = Console.ReadLine();
            System.Console.WriteLine("Enter a single digit");
            int dig = int.Parse(Console.ReadLine());
            bool inNum = false;
            for (int i = 0; i < num.Length; i++)
            {
                if ((int)num[i] == dig)
                {
                    inNum = true;
                }
            }
            if (!inNum)
            {
                System.Console.WriteLine(int.Parse(num) * 10 + dig);
            }
        }
        static void simPairs()
        {
            System.Console.WriteLine("Enter a pair of double digit numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int count = 0;
            while (20 <= num1 + num2 && num1 + num2 < 199)
            {
                if (num1 == num2 || (num1 % 10 == num2 / 10 && num1 / 10 == num2 % 10))
                {
                    System.Console.WriteLine("The two numbers are similar");
                    count++;
                }
                else System.Console.WriteLine("The two numbers aren't similar");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine(count);
        }
        static void maxRising()
        {
            System.Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int preNum;
            int max = 1;
            int current = 1;
            while (num != 0)
            {
                preNum = num;
                System.Console.WriteLine("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                if (num > preNum)
                {
                    current++;
                }
                else
                {
                    if (current > max)
                    {
                        max = current;
                    }
                    current = 1;
                }
            }
            System.Console.WriteLine("Largest rising sequence: " + max);
        }
        static void Main(string[] args)
        {
            maxRising();
        }
    }
}
