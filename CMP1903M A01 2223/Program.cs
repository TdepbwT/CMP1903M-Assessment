using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        static void Main(string[] args)
        {
          //create a new deck
          Pack pack = new Pack();
          List<Card> deck = pack.CreatePack();

          //print unshuffled deck
          Console.WriteLine("Unshuffled Deck:");
          foreach (Card card in deck)
            {
                Console.WriteLine(card.ToString());
            }

            //shuffle deck using chosen algorithm
            Console.WriteLine("Enter a shuffle method - 1 = Fisher-Yates, 2 = Riffle");
            int ShuffleChoice = int.Parse(Console.ReadLine());
            pack.shuffleCardPack(ShuffleChoice, deck);

            //print shuffled deck
            Console.WriteLine("Shuffled deck using chosen algorithm:");
            foreach (Card card in deck)
            {
                Console.WriteLine(card.ToString());
            }

            // create a new hand to deal cards to
            List<Card> hand = new List<Card>();

            // deal cards to new hands
            Console.WriteLine("Enter number of cards to deal");
            int numCards = int.Parse(Console.ReadLine());
            List<Card> dealtCards = pack.DealCard(numCards, deck, ref hand);

            //print cards dealt
            Console.WriteLine("Cards dealt to hand:");
            foreach(Card card in dealtCards)
            {
                Console.WriteLine(card.ToString());
            }

            //print remaining cards in deck
            Console.WriteLine("Cards left in deck");
            foreach (Card card in deck)
            {
                Console.WriteLine(card.ToString());
            }

            //print cards in hand
            Console.WriteLine("Cards in hand: ");
            foreach (Card card in hand)
            {
                Console.WriteLine(card.ToString());
            }






        }
    }
}
