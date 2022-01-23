using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDecks
{
    class Card
    {
        public Suit Suit { get; private set; }
        public Value Value { get; private set; }
        public override string ToString()
        {
            return Name;
        }

        public Card(Suit suit, Value value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public string Name
        {
            get { return $"{Value} of {Suit}"; }
        }
    }
}
