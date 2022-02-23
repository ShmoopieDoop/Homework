namespace homework_12
{
    public class Computer
    {
        string name;
        int speed;
        int memory;
        int price;
        public Computer(string name, int speed, int memory, int price)
        {
            this.name = name;
            this.speed = speed;
            this.memory = memory;
            this.price = price;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetSpeed()
        {
            return this.speed;
        }
        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }
        public void UpdateMem(int memory)
        {
            this.memory += memory;
        }
        public int GetMem()
        {
            return this.memory;
        }
        public int GetPrice()
        {
            return this.price;
        }
        public void SetPrice(int price)
        {
            this.price = price;
        }
        public string Info()
        {
            return $"Name: {this.name}\nSpeed: {this.speed}Mhz\nMemory: {this.memory}GB\nPrice: {this.price}$";
        }
    }
}