using System;

namespace homework_1
{
    class Program
    {
        static void p49e5(int num1, int num2)
        {
            // Swap 2 ints in multiple ways
            // Dana's implementation
            num1 = num2;
            num2 = num1;
            // Reut's implementation
            int t1 = num1;
            int t2 = num2;
            num1 = t2;
            num2 = t1;
            // Roy's implementation
            int temp = num1;
            num1 = num2;
            num2 = temp;
            // Another possible implementation
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
        }
        static double[] p50e9(double height, double vertice)
        {
            // calc P and S of a triangle
            double perimiter = vertice * 3;
            double surface = (vertice * height) / 2;
            return new double[] { perimiter, surface };
        }
        static int p50e10(int ten_point, int hundred_point, int thousand_point)
        {
            // calc amount of 
            return (ten_point * 10 + hundred_point * 100 + thousand_point * 1000);
        }
        static double p50e12(double F)
        {
            // Farenheit to Celsius concersion
            return (5.0 / 9.0 * (F - 32));
        }
        static double p50e13(double day_rate, int day_hours_worked, int night_hours_worked, int weekend_hours_worked)
        {
            // calc earned pay for each type if rate
            double earned_day = day_rate * day_hours_worked;
            double earned_night = day_rate * night_hours_worked * 1.5;
            double earned_weekend = day_rate * weekend_hours_worked * 2;
            return (earned_day + earned_night + earned_weekend);
        }
        static double[] p50e14(double years)
        {
            // calc amount of days, hours, and seconds alive
            double days_lived = years * 365;
            double hours_lives = days_lived * 24;
            double seconds_lived = hours_lives * 3600;
            return new double[] { days_lived, hours_lives, seconds_lived };
        }
        static double p50e15(double a, double b, double c)
        {
            // return result of the equation ax + b = c
            return (c - b) / a;
        }
        static double rect_surface(double length, double height)
        {
            // return surface of a rectangle
            return length * height;
        }
        static int days_count(int years, int months, int days)
        {
            // return amount of days in specified years, months and days
            return years * 365 + months * 30 + days;
        }
        static void Main()
        {
            int total_days = 1020;
            int years_count = total_days / 365;
            int days_left_y = total_days % 365;
            int months_count = days_left_y / 30;
            int days_left_m = days_left_y % 30;
            int weeks_count = days_left_m / 7;
            int days_left_w = days_left_m % 7;
            System.Console.WriteLine(years_count);
            System.Console.WriteLine(months_count);
            System.Console.WriteLine(weeks_count);
            System.Console.WriteLine(days_left_w);
        }
    }
}