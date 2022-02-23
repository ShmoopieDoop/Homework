using System;

namespace homework_3
{
    class Program
    {
        static void p71ex11(int licence, int s, int sLim)
        {
            // congratulate driver if below speed limit 
            // else print their licence and fine amount
            if (s <= sLim)
            {
                Console.WriteLine("Good Job!"); return;
            }
            Console.WriteLine($"Licence: {licence}, Fine: {(s - sLim) * 30}NIS");
        }
        static int p71ex12(int num1, int num2, string sign)
        {
            // calc sum or differmce according to the specified sign
            if (sign == "+")
            {
                return (num1 + num2);
            }
            return (num1 - num2);
        }
        static bool p71ex13(int a, int b, int c)
        {
            // tests if 3 numbers make an arithmetic sequence
            if (b - a == c - b)
            {
                return true;
            }
            return false;
        }
        static bool p71ex14(int pal)
        {
            // tests if a 3 digit number is a palindrome
            if (pal / 100 == pal % 100)
            {
                return true;
            }
            return false;
        }
        static int p72ex16(int twoDig)
        {
            // adds one to each digit if the number is even else subtracts
            int ones, tens;
            if (twoDig % 2 == 0)
            {
                ones = twoDig % 10 + 1;
                tens = twoDig / 10 + 1;
            }
            else
            {
                ones = twoDig % 10 - 1;
                tens = twoDig / 10 - 1;
            }
            return tens + ones;
        }
    }
}
