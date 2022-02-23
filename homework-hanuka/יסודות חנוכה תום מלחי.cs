using System;

namespace homework_hanuka
{
    class Program
    {
        static void numberPairs()
        {
            System.Console.WriteLine("Enter a pair of numbers.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int diff = Math.Abs(num1 - num2);
            int i = 1;
            while (i < 21 && diff != 1 && (num1 < 0 || num2 < 0))
            {
                System.Console.WriteLine("The difference between them is " + diff);
                System.Console.WriteLine("Enter a pair of numbers.");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                diff = Math.Abs(num1 - num2);
                i++;
            }
            System.Console.WriteLine($"There were {i} pairs of numbers");
        }
        static void apples()
        {
            double weight;
            int countA = 0;
            int countB = 0;
            while (countA < 50 && countB < 70)
            {
                System.Console.WriteLine("Enter weight: ");
                weight = double.Parse(Console.ReadLine());
                if (150 < weight && weight < 250)
                {
                    countA++;
                }
                else countB++;
            }
            if (countA == 50)
            {
                System.Console.WriteLine("Box A is full");
            }
            else System.Console.WriteLine("Box B is full");
        }
        static void factoryWorkers()
        {
            System.Console.WriteLine("How many hourse did the worker work?");
            int hoursWorked = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("What is their hourly wage?");
            int hourlyWage = int.Parse(System.Console.ReadLine());
            int salary = hourlyWage * hoursWorked;
            if (hoursWorked > 150)
            {
                salary += 250;
            }
            int expenses = salary;
            double wageSum = hourlyWage;
            int workerCount = 1;
            double avgWage;
            while (hoursWorked != -999 && hoursWorked != -999)
            {
                System.Console.WriteLine("How many hourse did the worker work?");
                hoursWorked = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("What is their hourly wage?");
                hourlyWage = int.Parse(System.Console.ReadLine());
                salary = hourlyWage * hoursWorked;
                if (hoursWorked > 150)
                {
                    salary += 250;
                }
                expenses += salary;
                wageSum += hourlyWage;
                workerCount++;
            }
            avgWage = wageSum / workerCount;
            System.Console.WriteLine($"The total expenses are {expenses}");
            System.Console.WriteLine($"The average wage is {avgWage}");
        }
        static void fiboSmaller()
        {
            int num1 = 0;
            int num2 = 1;
            int temp;
            int n = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(num1);
            while (num2 < n)
            {
                System.Console.WriteLine(num2);
                temp = num1 + num2;
                num1 = num2;
                num2 = temp;
            }
            /*OUTPUT when n = 10: 
            0
            1
            1
            2
            3
            5
            8*/
        }
        static void fiboSum()
        {
            int num1 = 0;
            int num2 = 1;
            int temp;
            int n = int.Parse(System.Console.ReadLine());
            int sum = 0;
            while (num2 < n)
            {
                sum += num2;
                temp = num1 + num2;
                num1 = num2;
                num2 = temp;
            }
            System.Console.WriteLine(sum);
        }
        static void compWins()
        {
            int yourGuess, compGuess, count = 1;
            Random r = new Random();
            compGuess = r.Next(1, 101);
            System.Console.WriteLine("Enter your guess: ");
            yourGuess = int.Parse(Console.ReadLine());
            while ((count < 6) && (yourGuess != compGuess))
            {
                if (yourGuess > compGuess)
                {
                    System.Console.WriteLine("Your guess is too high");
                }
                else System.Console.WriteLine("Your guess is too low");
                count++;
                System.Console.WriteLine("Enter your guess: ");
                yourGuess = int.Parse(Console.ReadLine());
            }
            if (yourGuess == compGuess)
            {
                System.Console.WriteLine("You guessed the number in " + count + " tries");
            }
            else
            {
                System.Console.WriteLine("You ran out of guesses :(");
                System.Console.WriteLine("The correct number was " + compGuess);
            }

        }
        static void pairs()
        {
            System.Console.WriteLine("Enter a pair of numbers: ");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            int count = 0;
            while (num2 != 0)
            {
                if (num1 > num2)
                {
                    count++;
                }
                num1 = num2;
                System.Console.WriteLine("Enter another number: ");
                num2 = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            compWins();
        }
    }
}
