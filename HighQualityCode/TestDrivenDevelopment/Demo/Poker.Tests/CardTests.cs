using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace Poker.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestCardJackSpadesToString()
        {
            Card card = new Card(CardFace.Jack, CardSuit.Spades);
            string expected = "J♠";

            string actual = card.ToString();

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestCardTwoClubsToString()
        {
            Card card = new Card(CardFace.Two, CardSuit.Clubs);
            string expected = "2♣";

            string actual = card.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCardAceDiamondsToString()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Diamonds);
            string expected = "A♦";

            string actual = card.ToString();

            Assert.AreEqual(expected, actual);
        }
       
        [TestMethod]
        public void TestCardKingHeartsToString()
        {
            Card card = new Card(CardFace.King, CardSuit.Hearts);
            string expected = "K♥";

            string actual = card.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
