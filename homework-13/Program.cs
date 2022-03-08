using System;

namespace homework_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Family Levi = new Family("Levi", 2, 5);
            Console.WriteLine(Levi.TotalPayment());
            Levi.NewKid(7);
            Console.WriteLine(Levi.TotalPayment());
            Levi.NewKid(7);
            Console.WriteLine(Levi.TotalPayment());

            Family f1 = new Family("Cohen", 3, 5);
            Family f2 = new Family("Levi", 5, 6);
            Family f3 = new Family("Israel", 1, 7);
            Family f4 = new Family("Avraham", 1, 4);
            f4.NewKid(0);
            f2.NewKid(8);
            if (f1.TotalPayment() > f2.TotalPayment())
                Console.WriteLine(f1.GetFamily());
            else Console.WriteLine(f2.GetFamily());
            double sum = f3.TotalPayment() + f4.TotalPayment();
            Console.WriteLine(sum);
            /*Name: Levi
            No. of family members: 7
            No. of children: 6
            380*/
        }
    }
}
