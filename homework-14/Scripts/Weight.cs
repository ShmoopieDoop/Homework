namespace Scripts
{
    public class Weight
    {
        private int kilo; // 0 <= kilo
        private int gram; // 0 <= gram <= 999

        public Weight()
        {
            this.kilo = 0;
            this.gram = 0;
        }
        public Weight(int kilo, int gram)
        {
            this.kilo = kilo;
            this.gram = gram;
        }
        public Weight(int totalGram)
        {
            this.kilo = totalGram / 1000;
            this.gram = totalGram % 1000;
        }
        public int GetKilo()
        {
            return this.kilo;
        }
        public void SetKilo(int kilo)
        {
            this.kilo = kilo;
        }
        public int GetGram()
        {
            return this.gram;
        }
        public void SetGram(int gram)
        {
            this.gram = gram;
        }
        public void Add(Weight other)
        {
            this.kilo += other.kilo;
            this.gram += other.gram;
            if (this.gram >= 1000)
            {
                this.gram -= 1000;
                this.kilo++;
            }
        }
        public bool Less(Weight other)
        {
            if (this.kilo < other.kilo)
                return true;
            else if (this.kilo > other.kilo)
                return false;
            else
                return this.gram < other.gram;
        }
    }
}