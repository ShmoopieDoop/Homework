namespace Scripts
{
    public class PairOfNums
    {
        private int num1;
        private int num2;
        public PairOfNums(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public int GetNum1()
        {
            return this.num1;
        }
        public void SetNum1(int num1)
        {
            this.num1 = num1;
        }
        public int GetNum2()
        {
            return this.num2;
        }
        public void SetNum2(int num2)
        {
            this.num2 = num2;
        }
        private bool CalcEndStart(int a, int b)
        {
            int highestDigit = a;
            while (highestDigit > 10) highestDigit /= 10;
            int lowestDigit = b % 10;
            return highestDigit == lowestDigit;
        }
        public bool EndStart()
        {
            return this.CalcEndStart(num1, num2) || this.CalcEndStart(num2, num1);
        }
    }
}