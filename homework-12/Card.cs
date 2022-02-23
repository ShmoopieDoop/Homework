using System;

namespace homework_12
{
    public class Card
    {
        int suit; // 1 - 4
        int value; // 1 - 13
        public Card(int suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }
        public Card()
        {
            Random r = new();
            this.suit = r.Next(1, 5);
            this.value = r.Next(1, 14);
        }
        public int GetSuit()
        {
            return this.suit;
        }
        public void SetSuit(int suit)
        {
            this.suit = suit;
        }
        public int GetValue()
        {
            return this.value;
        }
        public void SetValue(int value)
        {
            this.value = value;
        }
        public string GetInfo()
        {
            string icon;
            string letter;
            switch (this.suit){
                case 1:
                    icon = "♠";
                    break;
                case 2:
                    icon = "♥";
                    break;
                case 3:
                    icon = "♣";
                    break;
                case 4:
                    icon = "♦";
                    break;
                default:
                    icon = "";
                    break;
            }
            switch (this.value){
                case 11:
                    letter = "J";
                    break;
                case 12:
                    letter = "Q";
                    break;
                case 13:
                    letter = "K";
                    break;
                case 1:
                    letter = "A";
                    break;
                default:
                    letter = this.value.ToString();
                    break;
            }
            return icon + letter;
        }
        public bool isEqual(Card card)
        {
            return (this.value == card.value) && (this.suit == card.suit);
        }
    }
}