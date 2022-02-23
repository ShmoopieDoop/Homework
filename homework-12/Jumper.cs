namespace homework_12
{
    public class Jumper
    {
        string id;
        double record;
        double jump1;
        double jump2;
        double jump3;
        public Jumper(string id)
        {
            this.id = id;
            this.record = 0;
            this.jump1 = 0;
            this.jump2 = 0;
            this.jump3 = 0;
        }
        public string GetId()
        {
            return this.id;
        }
        public double GetRecord()
        {
            return this.record;
        }
        public double GetJump1()
        {
            return this.jump1;
        }
        public double GetJump2()
        {
            return this.jump2;
        }
        public double GetJump3()
        {
            return this.jump3;
        }
        public void SetId(string id)
        {
            this.id = id;
        }
        public void SetRecord(double record)
        {
            this.record = record;
        }
        public void SetJump1(double jump1)
        {
            this.jump1 = jump1;
        }
        public void SetJump2(double jump2)
        {
            this.jump2 = jump2;
        }
        public void SetJump3(double jump3)
        {
            this.jump3 = jump3;
        }
        public override string ToString()
        {
            return $"Id: {this.id}\nRecord: {this.record}\nJump History:\n  First Jump: {this.jump1}\n  Second Jump: {this.jump2}\n  Last Jump: {this.jump3}";
        }
        public double Avg()
        {
            return (this.jump1 + this.jump2 + this.jump3) / 3;
        }
        public bool EqualToLast()
        {
            return (this.jump1 == record) || (this.jump2 == record) || (this.jump3 == record);
        }
    }
}