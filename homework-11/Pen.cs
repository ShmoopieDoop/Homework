using System;

namespace homework_11
{
    public class Pen
    {
        int InkAmount = 100;
        bool IsOpen = false;
        public void fillInk()
        {
            this.InkAmount = 100;
        }
        public void toggleOpen()
        {
            this.IsOpen = !this.IsOpen;
        }
        public void write(string text)
        {
            Console.WriteLine(text);
            this.InkAmount -= 1;
        }
    }
}