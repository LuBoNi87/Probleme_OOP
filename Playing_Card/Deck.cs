using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_Card
{
    internal class Deck
    {
        const int NrCards = 52;
        Card[] deck;
        public Deck()
        {
            deck = new Card[NrCards];
        }
        public Card[] getDeck { get { return deck; } }

        public void CreateDeck()
        {
            int i = 0;
                foreach (Card.Suit s in Enum.GetValues(typeof(Card.Suit)))
                {
                foreach (Card.Value v in Enum.GetValues(typeof(Card.Value)))
                    deck[i++] = new Card { suit = s, value = v };
                }
        }
        public void ShuffleDeck()
        {
            Random random = new Random();
            Card temp;
            for (int i=0; i<NrCards-1; i++)
            {
                int j = random.Next(i, NrCards);
                temp = deck[j];
                deck[j] = deck[i];
                deck[i] = temp;
            }
        }
        public void GetCard()
        {
            Random random = new Random();
            int i = random.Next(0, NrCards);
            Console.WriteLine($"{deck[i].value.ToString()} of {deck[i].suit.ToString()}");
        }
    }
}
