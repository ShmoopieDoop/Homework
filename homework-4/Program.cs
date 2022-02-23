using System;

namespace homework_4
{
    class Program
    {
        static bool[] p79ex22()
        {
            int a = 0;
            int b = -3;
            int c = 9;
            bool d = true;
            return new bool[] {
                ((a<b)&&(a<c)&&(a<10)),
                ((a<b)||(a<c)||(a<10)),
                ((a<b)||(a<c)&&(a<10)),
                ((a<b)||(a<c)&&(a<10)||(b<a)),
                ((a<b)||(a<c))&&((a<10)||(b>a)),
                (((a<b)||(a<c))&&(a<10)||(b>a)),
                (!(!d)&&(!(5*7==50))),
                ((a!=b)&&(!(b*(-3)==c))),
                (!(c/3==3)||(!d))
            };
        }
        static bool[] p80ex24(int a, int b, int c)
        {
            return new bool[] { (a > b || b > c && a % 2 == 0),
                                ((a > b || b > c) && a % 2 == 0) };
        }
        static bool p80ex28(int student_cnt)
        {
            return (student_cnt % 2 != 0
            && student_cnt % 3 != 0
            && student_cnt % 4 != 0);
        }
        static void p84ex35(int a, int b)
        {
            if (a % 2 == 0 && b % 2 == 0)
            {
                if (a > b) { System.Console.WriteLine("1"); }
                else
                {
                    if (a < b) { System.Console.WriteLine("2"); }
                }
            }
            else
            {
                if (a % 2 != 0) { System.Console.WriteLine("3"); }
            }
        }
        static void p85ex43(int edge1, int edge2, int edge3)
        {
            if (edge1 != edge2 && edge1 != edge3 && edge2 != edge3)
            {
                System.Console.WriteLine("Scalene triangle");
            }
            else
            {
                if (edge1 == edge2 || edge1 == edge3 || edge2 == edge3)
                {
                    System.Console.WriteLine("Isoceles triangle");
                }
                if (edge1 == edge2 && edge1 == edge3)
                {
                    System.Console.WriteLine("Equelateral triangle");
                }
            }
        }
    }
}
