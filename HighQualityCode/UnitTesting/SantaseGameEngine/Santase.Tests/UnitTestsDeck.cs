namespace Santase.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    using Santase.Logic;
    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTests
    {
        private const int DeckCardsCount = 24;

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(DeckCardsCount)]
        public void TestGetNextCardReturnsCard(int cardsCountToGet)
        {
            Deck deck = new Deck();

            for (int i = 0; i < cardsCountToGet; i++)
            {
                Card card = deck.GetNextCard();
                Assert.AreNotEqual(card, null, string.Format("{0}th got card is null", i));
            }
        }

        [Test]
        public void TestGetNextCardsLeftIsCorrect()
        {
            Deck deck = new Deck();

            for (int i = 0; i < DeckCardsCount; i++)
            {
                Card card = deck.GetNextCard();
                Assert.AreEqual(deck.CardsLeft, DeckCardsCount - (i + 1), string.Format("After {0}th card is get cards count is not correct", i));
            }
        }

        [TestCase(DeckCardsCount)]
        public void TestGetNextCardReturnsDifferentCard(int cardsCountToGet)
        {
            Deck deck = new Deck();
            List<Card> cards = new List<Card>();

            for (int i = 0; i < cardsCountToGet; i++)
            {
                Card card = deck.GetNextCard();

                Assert.False(cards.Any(c => c.Suit == card.Suit && c.Type == card.Type));

                cards.Add(card);
            }
        }

        [Test]
        [ExpectedException(typeof(InternalGameException))]
        public void TestGetNextCardIfDeckIsEmptyThrowsInternalGameException()
        {
            Deck deck = new Deck();

            for (int i = 0; i <= DeckCardsCount; i++)
            {
                Card card = deck.GetNextCard();
            }
        }

        [Test]
        public void TestGetTrumpCardIsNotNull()
        {
            Deck deck = new Deck();

            Card card = deck.GetTrumpCard;

            Assert.AreNotEqual(card, null, " TrumpCard card is null");
        }

        [Test]
        public void TestChangeTrumpCard()
        {
            Deck deck = new Deck();

            Card trumpCardBeforeChange = deck.GetTrumpCard;
            Card card = deck.GetNextCard();
            deck.ChangeTrumpCard(card);
            Card trumpCardAfterChange = deck.GetTrumpCard;

            Assert.AreNotEqual(trumpCardAfterChange, null, " TrumpCard card is null after change");
            Assert.True(
                card.Suit.CompareTo(trumpCardAfterChange.Suit) == 0 ||
            card.Type.CompareTo(trumpCardAfterChange.Type) == 0,
            " TrumpCard card is not the same as passed card");
        }
    }
}
