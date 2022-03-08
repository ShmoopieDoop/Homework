using System;

namespace homework_13
{
    public class Family
    {
        string name;
        int numKids;
        int num;
        public Family(string name, int numKids, int num)
        {
            if (numKids >= num)
            {
                throw new ArgumentOutOfRangeException("A Family must have at least one adult.");
            }
            this.name = name;
            this.numKids = numKids;
            this.num = num;
        }
        public double TotalPayment()
        {
            double pay = this.numKids * 200;
            if ((num > 6 && numKids >= 1) || numKids > 3)
            {
                pay *= .9;
            }
            return pay;
        }
        public void NewKid(int age)
        {
            this.num++;
            if ((age >= 6) && (age <= 18)) this.numKids++;
        }
        public string GetFamily()
        {
            return $"Name: {this.name}\nNo. of family members: {this.num}\nNo. of children: {this.numKids}";
        }
    }
}