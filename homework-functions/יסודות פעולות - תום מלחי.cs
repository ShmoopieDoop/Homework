using System;

namespace homework_functions
{
    class Program
    {

        /*
        Question 1:
        1. חוקי
        2. לא חוקי. הפעולה מחזריה בוליאן ואי אפשר להשוות בוליאן למספר
        3. לא חוקי. לא ניתן להעביר מספר כתו
        4. חוקי אבל במידה והפעולה תחזיר נכון התכנית לא תצא מהלולאה עד שיגמר הזיכרון
        5. חוקי
        */
        static bool isLegal(int speed)
        {
            return 50 <= speed && speed <= 90;
        }
        static double avg(int sum, int count)
        {
            return (double)sum / count;
        }
        static void q2()
        {
            Console.WriteLine("What speed were you driving at?");
            int speed = int.Parse(Console.ReadLine());
            int sumIlegal = isLegal(speed) ? 0 : speed;
            int count = isLegal(speed) ? 0 : 1;
            for (int i = 0; i < 29; i++)
            {
                Console.WriteLine("What speed were you driving at?");
                speed = int.Parse(Console.ReadLine());
                if (isLegal(speed))
                {
                    System.Console.WriteLine("You are driving within the speed limit");
                }
                else
                {
                    System.Console.WriteLine("You are a wanted criminal");
                    count++;
                    sumIlegal += speed;
                }
            }
            Console.WriteLine("Average criminal speed: " + avg(sumIlegal, count));
        }
        /*
        ok = what(75, 37);
        ok == true
        הפעולה בודקת אם הספרה הכי משמעותית שווה בשני המספרים
        what(21, 54) == false
        what(25, 276) == true
        */
    }
}
