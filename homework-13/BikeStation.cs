using System;

namespace homework_13
{
    public class BikeStation
    {
        string name;
        int max;
        int current;
        public BikeStation(string name, int max)
        {
            this.name = name;
            this.max = max;
            this.current = max / 2;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetCurrent()
        {
            return this.current;
        }
        public void SetCurrent(int current)
        {
            if (current > this.max) throw new ArgumentOutOfRangeException("Max capacity reached");
            this.current = current;
        }
        public bool isFull()
        {
            return this.current == this.max;
        }
        public int EmptyPlaces()
        {
            if (this.current == 0) return 1;
            if (this.current < this.max / 2) return 2;
            return 3;
        }
    }
}