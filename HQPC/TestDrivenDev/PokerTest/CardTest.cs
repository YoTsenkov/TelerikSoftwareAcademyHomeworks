namespace PokerTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void ToString()
        {
            var card = new Card(CardFace.Ace, CardSuit.Hearts);
            var actual = card.ToString();
            Assert.AreEqual("Ace of Hearts", actual);
        }
    }
}
