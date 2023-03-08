using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13, 1 = Ace, Jack = 11, Queen = 12, King = 13
        //Suit: numbers 1 - 4; 1 = diamond, 2 = heart, 3 = spade, 4 = club
        //The 'set' methods for these properties could have some validation
        public int Value { get; set; }
        public int Suit { get; set; }

        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }

        public override string ToString()
        {
            string value_String;
            switch(Value)
            {
                case 1:
                    value_String = "Ace";
                    break;
                case 11:
                    value_String = "Jack";
                    break;
                case 12:
                    value_String = "Queen";
                    break;
                case 13:
                    value_String = "King";
                    break;
                default:
                    value_String = Value.ToString();
                    break;
            }

            string suit_String;
            switch (Suit)
            {
                case 1:
                    suit_String = "Diamonds";
                    break;
                case 2:
                    suit_String = "Hearts";
                    break;
                case 3:
                    suit_String = "Spades";
                    break;;
                default:
                    suit_String = "Clubs";
                    break;
            }

            return $"{value_String} of {suit_String}";
        }
    }
}
