using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public const int HandCardsCount = 5;

        public bool IsValidHand(IHand hand)
        {
            // check count
            if (hand.Cards.Count != HandCardsCount)
            {
                return false;
            }

            // check are different
            bool isValid = true;

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = 0; j < hand.Cards.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (hand.Cards[i].Equals(hand.Cards[j]))
                    {
                        isValid = false;
                        break;
                    }
                }

                if (!isValid)
                {
                    break;
                }
            }

            return isValid;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            if (!this.IsOneSuit(hand))
            {
                return false;
            }

            if (this.IsSerial(hand))
            {
                return false;
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

        private bool IsSerial(IHand hand)
        {
            IList<ICard> cards = hand.Cards;

            IList<ICard> cardsOrdered = cards.OrderBy(c => c.Face).ToList<ICard>();

            bool isSerial = true;

            CardFace face = cardsOrdered[0].Face;
            int faceNumber = (int)face;

            for (int i = 1; i < cardsOrdered.Count; i++)
            {
                int currentFaceNumber = (int)cardsOrdered[i].Face;
                if (currentFaceNumber != (faceNumber + 1))
                {
                    isSerial = false;
                    break;
                }

                faceNumber = currentFaceNumber;
            }

            return isSerial;
        }

        private bool IsOneSuit(IHand hand)
        {
            bool isOneSuit = true;

            CardSuit suit = hand.Cards[0].Suit;

            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].Suit != suit)
                {
                    isOneSuit = false;
                    break;
                }
            }

            return isOneSuit;
        }
    }
}
