using System;

namespace homework_2
{
    class Program
    {
        static int newNum(int num)
        {
            int newNum = num + 5;
            newNum = newNum / 10;
            newNum = newNum * 10;
            return newNum;
        }
        static int[] p2ex1(int n)
        {
            /* calc how many groups of five students 
            can be made and how many students will 
            be left without a group */
            int groupCount = n / 5;
            int groupless = n % 5;
            return new int[] { groupless, groupCount };
        }
        static int[] p2ex2(int n, int m)
        {
            // Add groupless students to a new class and repeat ex1
            int nGroupCount = n / 5;
            int nGroupless = n % 5;
            int mGroupCount = (m + nGroupless) / 5;
            int mGroupless = (m + nGroupless) % 5;
            return new int[] { mGroupCount, mGroupless };
        }
        static int p2ex3(int oneDig, int twoDig)
        {
            /* return three digit number where
            the first and last digits are the
            two digit number and the second 
            digit is the single digit number */
            return (twoDig / 10 * 100) + (oneDig * 10) + (twoDig % 10);
        }
        static int p2ex4(int fourDigit)
        {
            // Make the least significant digit the most significant digit
            return fourDigit / 10 + (fourDigit % 10) * 1000;
        }
        static int p2ex5(int fourDigit)
        {
            // Swap 2 right digits with 2 left digits
            return (fourDigit / 100) + (fourDigit % 100) * 100;
        }
        static int p2ex6(int doubleDigit){
            return (doubleDigit / 10 + doubleDigit % 10 * 10) + 1;
        }
        static void Main()
        {
            Console.WriteLine(p2ex3(8, 17));
            Console.WriteLine(p2ex4(3487));
            Console.WriteLine(p2ex5(5678));
            Console.WriteLine(p2ex6(56));
            /*
            Output:
            1. 187
            2. 7348
            3. 7856
            4. 66
            */
        }
    }
}
