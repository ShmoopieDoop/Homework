namespace Scripts
{
    public class Doctor
    {
        private string name;
        private string specialization;
        private int rate; // 0 <= rate <= 10
        public Doctor(string name, string specialization)
        {
            this.name = name;
            this.specialization = specialization;
            this.rate = 0;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetSpecialization()
        {
            return this.specialization;
        }
        public void SetSpecialization(string specialization)
        {
            this.specialization = specialization;
        }
        public int GetRate()
        {
            return this.rate;
        }
        public void SetRate(int rate)
        {
            this.rate = rate;
        }

    }
}