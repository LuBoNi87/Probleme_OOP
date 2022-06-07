using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_Card
{
    internal class Deck : Card
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
                foreach (Suit s in Enum.GetValues(typeof(Suit)))
                {
                foreach (Value v in Enum.GetValues(typeof(Value)))
                    deck[i++] = new Card { suit = s, value = v };
                }
        }
        public void ShuffleDeck()
        {
            Random random = new Random();
            Card temp;
            for (int j = 0; j < 1000; j++)
            {
                for (int i = 0; i < NrCards; i++)
                {
                    int swapCard = random.Next(52);
                    temp = deck[i];
                    deck[i] = deck[swapCard];
                    deck[swapCard] = temp;
                }
            }
        }
        public void ShowDeck()
        {
            for (int i = 0; i < NrCards; i++)
            {
                Console.WriteLine($"{deck[i].suit.ToString()} {deck[i].value.ToString()}");
            }
        }
    }
}
