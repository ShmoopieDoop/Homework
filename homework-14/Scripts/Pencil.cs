namespace Scripts
{
    public class Pencil
    {
        private int length;
        private bool sharpened;
        public Pencil(int length, bool sharpened)
        {
            this.length = length;
            this.sharpened = sharpened;
        }
        public bool IsLonger(Pencil other)
        {
            return this.length > other.length;
        }
        public bool IsSharpened()
        {
            return this.sharpened;
        }
        /*
        Created Objects:
        Pencil1: length 12 sharpened
        Pencil2: length 13 not sharpened
        
        OUTPUT:
        "pencil2 need to be sharpened"
        */
    }
}