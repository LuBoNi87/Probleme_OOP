using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.CreateDeck();
            deck.ShuffleDeck();
            bool running = true;
            string actiune;
            Console.WriteLine("1. - Extrage o carte");
            Console.WriteLine("2. - Amestecă pachetul");
            while(running)
            {
                actiune=Console.ReadLine().ToString();
                switch (actiune)
                {
                    case "1":
                        deck.GetCard();
                        break;
                    case "2":
                        deck.ShuffleDeck();
                        break;
                    default:
                        running = false;
                        break;
                }
            }
        }
    }
}
