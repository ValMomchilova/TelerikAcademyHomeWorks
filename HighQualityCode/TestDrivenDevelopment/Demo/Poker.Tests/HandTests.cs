using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace Poker.Tests
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void TestStraightHand()
        {
            IList<ICard> cards = new List<ICard>();
            
            Card card1 = new Card(CardFace.Ace, CardSuit.Spades);
            cards.Add(card1);
            
            Card card2 = new Card(CardFace.King, CardSuit.Clubs);
            cards.Add(card2);
            
            Card card3 = new Card(CardFace.Queen, CardSuit.Diamonds);
            cards.Add(card3);
           
            Card card4 = new Card(CardFace.Jack, CardSuit.Hearts);
            cards.Add(card4);
            
            Card card5 = new Card(CardFace.Ten, CardSuit.Diamonds);
            cards.Add(card5);

            Hand hand = new Hand(cards);

            string expected = "A♠ K♣ Q♦ J♥ 10♦ ";
            string actual = hand.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestHandEmptyToString()
        {
            IList<ICard> cards = new List<ICard>();
            Hand hand = new Hand(cards);

            string expected = string.Empty;
            string actual = hand.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsHandWithFiveDifferentCardsValid()
        {
            IList<ICard> cards = new List<ICard>();

            Card card1 = new Card(CardFace.Ace, CardSuit.Spades);
            cards.Add(card1);

            Card card2 = new Card(CardFace.King, CardSuit.Clubs);
            cards.Add(card2);

            Card card3 = new Card(CardFace.Queen, CardSuit.Diamonds);
            cards.Add(card3);

            Card card4 = new Card(CardFace.Jack, CardSuit.Hearts);
            cards.Add(card4);

            Card card5 = new Card(CardFace.Ten, CardSuit.Diamonds);
            cards.Add(card5);

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();

            bool actual = checker.IsValidHand(hand);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsHandWithFiveNotDifferentCardsValid()
        {
            IList<ICard> cards = new List<ICard>();

            Card card1 = new Card(CardFace.Ace, CardSuit.Spades);
            cards.Add(card1);

            Card card2 = new Card(CardFace.King, CardSuit.Clubs);
            cards.Add(card2);

            Card card3 = new Card(CardFace.Ace, CardSuit.Spades);
            cards.Add(card3);

            Card card4 = new Card(CardFace.Jack, CardSuit.Hearts);
            cards.Add(card4);

            Card card5 = new Card(CardFace.Ten, CardSuit.Diamonds);
            cards.Add(card5);

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();

            bool actual = checker.IsValidHand(hand);
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsHandWithFourDifferentCardsValid()
        {
            IList<ICard> cards = new List<ICard>();

            Card card1 = new Card(CardFace.Ace, CardSuit.Spades);
            cards.Add(card1);

            Card card2 = new Card(CardFace.King, CardSuit.Clubs);
            cards.Add(card2);

            Card card3 = new Card(CardFace.Queen, CardSuit.Diamonds);
            cards.Add(card3);

            Card card4 = new Card(CardFace.Jack, CardSuit.Hearts);
            cards.Add(card4);

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();

            bool actual = checker.IsValidHand(hand);
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsHandWithFourNotDifferentCardsValid()
        {
            IList<ICard> cards = new List<ICard>();

            Card card1 = new Card(CardFace.Ace, CardSuit.Spades);
            cards.Add(card1);

            Card card2 = new Card(CardFace.King, CardSuit.Clubs);
            cards.Add(card2);

            Card card3 = new Card(CardFace.Ace, CardSuit.Spades);
            cards.Add(card3);

            Card card4 = new Card(CardFace.Jack, CardSuit.Hearts);
            cards.Add(card4);
            
            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();

            bool actual = checker.IsValidHand(hand);
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsFlushFiveDifferentFaceEaqualSuitsNotSerial()
        {
            IList<ICard> cards = new List<ICard>();

            Card card1 = new Card(CardFace.Ace, CardSuit.Spades);
            cards.Add(card1);

            Card card2 = new Card(CardFace.Ten, CardSuit.Spades);
            cards.Add(card2);

            Card card3 = new Card(CardFace.Queen, CardSuit.Spades);
            cards.Add(card3);

            Card card4 = new Card(CardFace.Jack, CardSuit.Spades);
            cards.Add(card4);

            Card card5 = new Card(CardFace.Seven, CardSuit.Spades);
            cards.Add(card5);

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();

            bool actual = checker.IsFlush(hand);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsFlushFiveDifferentFaceEaqualSuitsSerial()
        {
            IList<ICard> cards = new List<ICard>();

            Card card1 = new Card(CardFace.Ace, CardSuit.Spades);
            cards.Add(card1);

            Card card2 = new Card(CardFace.Ten, CardSuit.Spades);
            cards.Add(card2);

            Card card3 = new Card(CardFace.Queen, CardSuit.Spades);
            cards.Add(card3);

            Card card4 = new Card(CardFace.Jack, CardSuit.Spades);
            cards.Add(card4);

            Card card5 = new Card(CardFace.King, CardSuit.Spades);
            cards.Add(card5);

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();

            bool actual = checker.IsFlush(hand);
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsFlushFiveDifferentFaceDifferentSuitsNotSerial()
        {
            IList<ICard> cards = new List<ICard>();

            Card card1 = new Card(CardFace.Ace, CardSuit.Spades);
            cards.Add(card1);

            Card card2 = new Card(CardFace.Two, CardSuit.Spades);
            cards.Add(card2);

            Card card3 = new Card(CardFace.Queen, CardSuit.Clubs);
            cards.Add(card3);

            Card card4 = new Card(CardFace.Jack, CardSuit.Spades);
            cards.Add(card4);

            Card card5 = new Card(CardFace.Seven, CardSuit.Spades);
            cards.Add(card5);

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();

            bool actual = checker.IsFlush(hand);
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsFlushFourDifferentFaceEaqualSuitsNotSerial()
        {
            IList<ICard> cards = new List<ICard>();

            Card card1 = new Card(CardFace.Ace, CardSuit.Spades);
            cards.Add(card1);

            Card card2 = new Card(CardFace.Ten, CardSuit.Spades);
            cards.Add(card2);

            Card card3 = new Card(CardFace.Queen, CardSuit.Spades);
            cards.Add(card3);

            Card card4 = new Card(CardFace.Jack, CardSuit.Spades);
            cards.Add(card4);

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();

            bool actual = checker.IsFlush(hand);
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }
    }
}
