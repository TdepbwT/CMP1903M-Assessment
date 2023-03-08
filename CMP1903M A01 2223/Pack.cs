using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public List<Card> CreatePack() //Initialise the card pack here
        {
            List<Card> pack = new List<Card>();
            
            for (int suit = 0; suit < 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    Card card = new Card(value, suit);
                    pack.Add(card);
                }
            }
            return pack;
        }

        public bool shuffleCardPack(int typeOfShuffle, List<Card> pack) //Shuffles the pack based on the type of shuffle; Fisher-Yates or Riffle
        {
            switch (typeOfShuffle) // uses a switch to select type of shuffle, default is no shuffle
            {
                case 1:
                    FisherYatesShuffle(pack);
                    return true;

                case 2:
                    RiffleShuffle(pack);
                    return true;

                default:
                    return false;
            }
        }

        private static bool FisherYatesShuffle(List<Card> CreatePack)
        {
            if (CreatePack == null || CreatePack.Count == 0)
            {
                return false;
            }

            Random rng = new Random();
            int n = CreatePack.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card temp = CreatePack[k];
                CreatePack[k] = CreatePack[n];
                CreatePack[n] = temp;
            }

            return true;
        }

        private static bool RiffleShuffle(List<Card> CreatePack)
        {
            if (CreatePack == null || CreatePack.Count == 0)
            {
                return false;
            }

            Random rng = new Random();
            int n = CreatePack.Count / 2;
            for (int i = 0; i < 5; i++)
            {
                List<Card> leftHalf = CreatePack.GetRange(0, n);
                List<Card> rightHalf = CreatePack.GetRange(n, n);
                CreatePack.Clear();  
                while (leftHalf.Count > 0 && rightHalf.Count > 0)
                {
                    if (rng.Next(2) == 0)
                    {
                        CreatePack.Add(leftHalf[0]);
                        leftHalf.RemoveAt(0);
                    }
                    else
                    {
                        CreatePack.Add(rightHalf[0]);
                        rightHalf.RemoveAt(0);
                    }
                }
                CreatePack.AddRange(leftHalf);
                CreatePack.AddRange(rightHalf);
            }   

            return true;
        }



        public static Card DealCard(List<Card> hand) // deals the card at the top of the pack; don't even know if this works
        {
            Card card = hand[0];
            hand.RemoveAt(0);
            return card;
        }

        public List<Card> DealCard(int amount, List<Card> pack, ref List<Card> hand)
        {
          List<Card> dealtCards = new List<Card>();

          if (pack.Count < amount) // error handling
          {
            Console.WriteLine("Not enough cards in deck to deal");
            return dealtCards;
          }

          for (int i = 0; i < amount; i++)
            {
                Card card = pack[0];
                dealtCards.Add(card);
                pack.Remove(card);
            }
          hand.AddRange(dealtCards);
          return dealtCards;
        }



    }
}
