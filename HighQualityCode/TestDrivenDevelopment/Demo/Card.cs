using System;
using System.Collections.Generic;

namespace Poker
{
    public class Card : ICard
    {
        private static readonly Dictionary<CardFace, string> FaceStrings =
            new Dictionary<CardFace, string>()
        {
            { CardFace.Two, "2" },
            { CardFace.Three, "3" },
            { CardFace.Four, "4" },
            { CardFace.Five, "5" },
            { CardFace.Six, "6" },
            { CardFace.Seven, "7" },
            { CardFace.Eight, "8" },
            { CardFace.Nine, "9" },
            { CardFace.Ten, "10" },
            { CardFace.Jack, "J" },
            { CardFace.Queen, "Q" },
            { CardFace.King, "K" },
            { CardFace.Ace, "A" },
        };

        private static readonly Dictionary<CardSuit, string> SuitStrings =
            new Dictionary<CardSuit, string>()
        {
            { CardSuit.Clubs, "♣" },
            { CardSuit.Diamonds, "♦" },
            { CardSuit.Hearts, "♥" },
            { CardSuit.Spades, "♠" }
        };       

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public CardFace Face { get; private set; }

        public CardSuit Suit { get; private set; }

        public int CompareTo(object otherCard)
        {
            Card card = otherCard as Card;

            if (this.Suit != card.Suit)
            {
                return (int)this.Suit - (int)card.Suit;
            }

            if (this.Face != card.Face)
            {
                return (int)this.Face - (int)card.Face;
            }           

            return 0;
        }

        public override bool Equals(object obj)
        {
            bool areEqual = this.CompareTo(obj) == 0;
            return areEqual;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", FaceStrings[this.Face], SuitStrings[this.Suit]);
        }
    }
}
