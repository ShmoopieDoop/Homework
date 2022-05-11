using System;

namespace Scripts
{
    class Program
    {
        public static PairOfNums generate(int n)
        {
            int a, b;
            int sumA = 0;
            int sumB = 0;
            Random r = new Random();
            PairOfNums p;
            int EndStartCount = 0;
            for (int i = 0; i < n; i++)
            {
                a = r.Next(1, 1001);
                b = r.Next(1, 1001);
                p = new PairOfNums(a, b);
                if (p.EndStart())
                {
                    sumA += a;
                    sumB += b;
                    EndStartCount++;
                    Console.WriteLine($"{a}, {b}");
                }
            }
            int num1 = sumA / EndStartCount;
            int num2 = sumB / EndStartCount;
            return new PairOfNums(num1, num2);
        }
        public static string Better(Doctor a, Doctor b)
        {
            if (a.GetSpecialization() != b.GetSpecialization())
                return "";
            if (a.GetRate() > b.GetRate())
                return a.GetName();
            if (a.GetRate() < b.GetRate())
                return b.GetName();
            return "same";
        }
        public static void doctorRating(Doctor d)
        {
            int rating = int.Parse(Console.ReadLine());
            if (rating == -1) return;
            int sum = 0;
            int count = 1;
            do
            {
                sum += rating;
                count++;
                rating = int.Parse(Console.ReadLine());
            } while (rating != -1);
            d.SetRate(sum / count);
        }
        static void Main(string[] args)
        {
            Doctor d = new Doctor("Moses", "Eyes");
            doctorRating(d);
            Console.WriteLine(d.GetRate());
        }
    }
}
