namespace PokerTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections.Generic;

    [TestClass]
    public class PokerHandsCheckerTest
    {
        [TestMethod]
        public void CheckValidHand()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsValidHand(hand));
        }

        [TestMethod]
        public void CheckInvalidHand()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades)
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsValidHand(hand));
        }

        [TestMethod]
        public void CheckHighCardHand()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsHighCard(hand));
        }

        [TestMethod]
        public void CheckOnePairCardHand()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsOnePair(hand));
        }

        [TestMethod]
        public void CheckTwoPairsHand()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsTwoPair(hand));
        }

        [TestMethod]
        public void CheckisThreeOfAKindHand()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsThreeOfAKind(hand));
        }

        [TestMethod]
        public void CheckStreightHand()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsStraight(hand));
        }

        [TestMethod]
        public void CheckFlushHand()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsFlush(hand));
        }

        [TestMethod]
        public void CheckFullHouseHand()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsFullHouse(hand));
        }

        [TestMethod]
        public void CheckStraightFlushHand()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
            });
            IPokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsStraightFlush(hand));
        }
    }
}
