using System;

namespace homework_9
{
    class Program
    {
        /*
        ex 15:
        1. לא חוקי. הוכנס שבר עשרוני לארגומנט int big
        2. לא חוקי. הפעולה יכולה לקבל רק שני ארגומנטים
        3. חוקי
        4. חוקי
        */

        static int SumOfDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        static void SmallerWithEqualSumOfDigits(int n)
        {
            int SumOfDigitsN = SumOfDigits(n);
            for (int i = 1; i < n; i++)
            {
                if (SumOfDigits(i) == SumOfDigitsN)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void DigitLocation(int n, int digit)
        {
            bool DigitInNum = false;
            double RptCount = Math.Log10(n) + 1;
            for (int i = 1; i <= RptCount; i++)
            {
                if (n % 10 == digit)
                {
                    Console.Write($"{i}, ");
                    DigitInNum = true;
                }
                n /= 10;
            }
            if (!DigitInNum)
            {
                Console.Write("0, ");
            }
        }
        static void EachDigitLocation(int n)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i} ==> ");
                DigitLocation(n, i);
                Console.WriteLine();
            }
        }
        static double UpdateDolarExchangeRate(double YesterdayRate, double ChangePercent)
        {
            return YesterdayRate + ChangePercent * YesterdayRate / 100;
        }
        static double GainOrLossIn10Days(double DolarsPurchased, double CurrentRate)
        {
            double ChangePercent = int.Parse(Console.ReadLine());
            double StartRate = CurrentRate;
            for (int i = 0; i < 10; i++)
            {
                CurrentRate = UpdateDolarExchangeRate(CurrentRate, ChangePercent);
                ChangePercent = int.Parse(Console.ReadLine());
            }
            double StartValue = StartRate * DolarsPurchased;
            double EndValue = CurrentRate * DolarsPurchased;
            return EndValue - StartValue;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GainOrLossIn10Days(10000, 3.5));
        }
    }
}
