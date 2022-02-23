using System;

namespace homework_5
{
    class Program
    {
        static void switch4(int salary, int level)
        {
            double tax = 0;
            switch (level)
            {
                case 1:
                case 2:
                    if (salary < 3500)
                    {
                        tax = 0.005;
                    }
                    else tax = 0.0075;
                    break;
                case 3:
                    if (salary < 5000)
                    {
                        tax = 0.01;
                    }
                    else tax = 0.0125;
                    break;
                case 4:
                    if (salary < 7500)
                    {
                        tax = 0.015;
                    }
                    else tax = 0.02;
                    break;
                default:
                    System.Console.WriteLine("Invalid level: " + level);
                    break;
            }
            System.Console.WriteLine($"You must pay {salary * tax}$ tax");
        }
        static void switch5(int week_day, int salary, int hours_worked)
        {
            double pay;
            double bonus = 1.25;
            int hours_for_bonus = 8;
            switch (week_day)
            {
                case 6:
                    hours_for_bonus = 5;
                    bonus = 2;
                    break;
                case 7:
                    hours_for_bonus = 5;
                    bonus = 3;
                    break;
                default:
                    System.Console.WriteLine("Invalid Day");
                    break;
            }
            if (hours_worked > hours_for_bonus)
            {
                pay = salary * hours_for_bonus + (hours_worked - hours_for_bonus) * salary * bonus;
            }
            else pay = salary * hours_worked;
            System.Console.WriteLine($"Your final pay is {pay}");
        }
        static void math7()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                double a = rnd.Next(-50, 50);
                double b = rnd.Next(-50, 50);
                double c = rnd.Next(-50, 50);
                System.Console.WriteLine($"Equation {i + 1}: {a}x^2 + {b}x + {c}");
                double delta = Math.Sqrt(b * b - 4 * a * c);
                double solution1 = (-b + delta) / (2 * a);
                double solution2 = (-b - delta) / (2 * a);
                System.Console.WriteLine($"The solutions to the equation are {solution1} and {solution2}");
            }
        }
        static void p107ex11()
        {
            int num, positive_or_negative;
            System.Console.WriteLine("Enter any number (positive or negative)");
            num = int.Parse(Console.ReadLine());
            positive_or_negative = num / Math.Abs(num);
            switch (positive_or_negative)
            {
                case 1:
                    System.Console.WriteLine("Your number is negative");
                    break;
                case -1:
                    System.Console.WriteLine("Your number is positive");
                    break;
            }
        }
        static void p107ex13()
        {
            int player_guess, roll_number;
            Random rnd = new Random();
            roll_number = rnd.Next(1, 7);
            System.Console.WriteLine("Guess any number on a 6 faced die");
            player_guess = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine($"Your guess: {player_guess}");
            System.Console.WriteLine($"Your roll: {roll_number}");
            if (roll_number == player_guess)
            {
                System.Console.WriteLine("You guessed correctly!");
            }
            else
            {
                System.Console.WriteLine("You guessed incorrectly");
                System.Console.WriteLine($"The difference between your roll and your guess is {Math.Abs(player_guess - roll_number)}");
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
