using System;

namespace homework_10
{
    class Program
    {
        static int CalcBonus(int grade, int units)
        {
            switch (units)
            {
                case 4:
                    return grade + 10;
                case 5:
                    return grade + 20;
                default:
                    return grade;
            }
        }
        static void FinalAvg()
        {
            int grade = int.Parse(Console.ReadLine());
            int units = int.Parse(Console.ReadLine());
            int TestCount = 0;
            double TotalGrade = 0;
            while (grade != -1)
            {
                TotalGrade += CalcBonus(grade, units);
                TestCount++;
                grade = int.Parse(Console.ReadLine());
                units = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(TotalGrade / TestCount);
        }
        static int ConvertToMinutes(int hours, int minutes)
        {
            return hours * 60 + minutes;
        }
        static int TimeBetween(int hours1, int minutes1, int hours2, int minutes2)
        {
            return ConvertToMinutes(hours2, minutes2) - ConvertToMinutes(hours1, minutes1);
        }
        static int DayMostWorked()
        {
            int HoursWorked = int.Parse(Console.ReadLine());
            int MinutesWorked = int.Parse(Console.ReadLine());
            int MaxWorkHours = HoursWorked;
            int MaxWorkMinutes = MinutesWorked;
            int MaxWorkIndex = 1;
            for (int i = 2; i <= 30; i++)
            {
                HoursWorked = int.Parse(Console.ReadLine());
                MinutesWorked = int.Parse(Console.ReadLine());
                if (TimeBetween(HoursWorked, MinutesWorked, MaxWorkHours, MaxWorkMinutes) > 0)
                {
                    MaxWorkIndex = i;
                    MaxWorkHours = HoursWorked;
                    MaxWorkMinutes = MinutesWorked;
                }
            }
            return MaxWorkIndex;
        }
        static int GetFirstDigit(int n)
        {
            return (int)(n / Math.Pow(10, Math.Floor(Math.Log10(n))));
        }
        static int AddVerificationDigit(int n)
        {
            int digit = (GetFirstDigit(n) + n % 10) % 10;
            return n * 10 + digit;
        }
        static void UpdatePasswords()
        {
            int password = int.Parse(Console.ReadLine());
            for (int i = 0; i < 100; i++)
            {
                password = AddVerificationDigit(password);
                password = AddVerificationDigit(password);
                Console.WriteLine(password);
                password = int.Parse(Console.ReadLine());
            }
        }
        static bool IsDigitInNum(int n, int digit)
        {
            while (n > 10)
            {
                if (n % 10 == digit) return true;
                n /= 10;
            }
            return false;
        }
        static int AreAllDigitsDifferent(int n)
        {
            int LastDigit = n % 10;
            while (n > 10)
            {
                if (IsDigitInNum(n, LastDigit))
                {
                    return 0;
                }
                n /= 10;
                LastDigit = n % 10;
            }
            return 1;
        }
        static void UntillAllDigitsAreDifferent()
        {
            int NumCount = 1;
            int num = int.Parse(Console.ReadLine());
            while (AreAllDigitsDifferent(num) == 0)
            {
                NumCount++;
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(NumCount);
            Console.WriteLine(num);
        }
    }
}
