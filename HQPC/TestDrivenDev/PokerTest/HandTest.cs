namespace PokerTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections.Generic;
    using System.Text;

    [TestClass]
    public class HandTest
    {
        [TestMethod]
        public void ToString()
        {
            var cards = new List<ICard>();
            cards.Add(new Card(CardFace.Jack, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.King, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Jack, CardSuit.Spades));
            cards.Add(new Card(CardFace.Five, CardSuit.Clubs));

            var hand = new Hand(cards);
           
            var actual = hand.ToString();
            var sb = new StringBuilder();
            foreach (var card in hand.Cards)
            {
                sb.AppendLine(card.ToString());
            }

            var expected = sb.ToString();
            Assert.AreEqual(actual, expected);
        }
    }
}
