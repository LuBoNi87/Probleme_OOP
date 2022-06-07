using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_Card
{
    public class Card
    {
        public enum Suit
        {
            Hearts,
            Spades,
            Diamonds,
            Clubs
        }
        public enum Value
        {
            Two = 2,Three,Four,Five,Six,Seven,Eight,Nine,Ten,Jack,Queen,King,Ace
        }
        public Suit suit { get; set; }
        public Value value { get; set; }
    }
}
