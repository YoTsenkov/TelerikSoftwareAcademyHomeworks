using System;
using System.Collections.Generic;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            int cardsCount = hand.Cards.Count;
            if (cardsCount != 5)
            {
                return false;
            }

            for (int i = 0; i < cardsCount - 1; i++)
            {
                var desiredFace = hand.Cards[i].Face;
                var desiredSuit = hand.Cards[i].Suit;
                for (int k = i + 1; k < cardsCount; k++)
                {
                    var currentFace = hand.Cards[k].Face;
                    var currentSuit = hand.Cards[k].Suit;
                    if (desiredFace == currentFace && desiredSuit == currentSuit)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            var desiredSuit = hand.Cards[0].Suit;
            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].Suit != desiredSuit)
                {
                    return false;
                }
            }

            var faces = new List<int>();
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                faces.Add((int)hand.Cards[i].Face);
            }
            faces.Sort();

            var currentFace = faces[0];
            for (int i = 1; i < faces.Count; i++)
            {
                var nextFace = faces[i];
                if (nextFace - currentFace != 1)
                {
                    return false;
                }

                currentFace = nextFace;
            }


            return true;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!IsValidHand(hand) || IsStraightFlush(hand))
            {
                return false;
            }

            var faces = new Dictionary<string, int>();
            foreach (var card in hand.Cards)
            {
                if (!faces.ContainsKey(card.Face.ToString()))
                {
                    faces.Add(card.Face.ToString(), 1);
                }
                else
                {
                    faces[card.Face.ToString()]++;
                }
            }

            foreach (var value in faces.Values)
            {
                if (value == 4)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            if (!IsValidHand(hand) || IsFourOfAKind(hand) 
                || IsStraightFlush(hand))
            {
                return false;
            }

            var faces = new Dictionary<string, int>();
            foreach (var card in hand.Cards)
            {
                if (!faces.ContainsKey(card.Face.ToString()))
                {
                    faces.Add(card.Face.ToString(), 1);
                }
                else
                {
                    faces[card.Face.ToString()]++;
                }
            }

            var counter = 0;
            if (faces.Values.Count == 2)
            {
                foreach (var value in faces.Values)
                {
                    if (value == 2 || value == 3)
                    {
                        counter++;
                    }
                }
            }

            if (counter == 2)
            {
                return true;
            }
            

            return false;
        }

        public bool IsFlush(IHand hand)
        {
            if (!IsValidHand(hand) || IsFullHouse(hand) ||
                IsFourOfAKind(hand) || IsStraightFlush(hand) || 
                IsStraightFlush(hand))
            {
                return false;
            }

            var desiredSuit = hand.Cards[0].Suit;
            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].Suit != desiredSuit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            if (!IsValidHand(hand) || IsFlush(hand) ||
                IsFullHouse(hand) || IsFourOfAKind(hand) ||
                IsStraightFlush(hand))
            {
                return false;
            }

            var faces = new List<int>();
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                faces.Add((int)hand.Cards[i].Face);
            }
            faces.Sort();

            var currentFace = faces[0];
            for (int i = 1; i < faces.Count; i++)
            {
                var nextFace = faces[i];
                if (nextFace - currentFace != 1)
                {
                    return false;
                }

                currentFace = nextFace;
            }

            return true;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            if (!IsValidHand(hand) || IsStraight(hand) ||
                IsFlush(hand) || IsFullHouse(hand) ||
                IsFourOfAKind(hand) || IsStraightFlush(hand))
            {
                return false;
            }

            var faces = new Dictionary<string, int>();
            foreach (var card in hand.Cards)
            {
                if (!faces.ContainsKey(card.Face.ToString()))
                {
                    faces.Add(card.Face.ToString(), 1);
                }
                else
                {
                    faces[card.Face.ToString()]++;
                }
            }

            foreach (var value in faces.Values)
            {
                if (value == 3)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsTwoPair(IHand hand)
        {
            if (!IsValidHand(hand) || IsThreeOfAKind(hand) ||
                IsStraight(hand) || IsFlush(hand) ||
                IsFullHouse(hand) || IsFourOfAKind(hand) || IsStraightFlush(hand))
            {
                return false;
            }

            var faces = new Dictionary<string, int>();
            foreach (var card in hand.Cards)
            {
                if (!faces.ContainsKey(card.Face.ToString()))
                {
                    faces.Add(card.Face.ToString(), 1);
                }
                else
                {
                    faces[card.Face.ToString()]++;
                }
            }

            int pairsCounter = 0;
            foreach (var value in faces.Values)
            {
                if (value == 2)
                {
                    pairsCounter++;
                }
            }

            if (pairsCounter == 2)
            {
                return true;
            }

            return false;
        }

        public bool IsOnePair(IHand hand)
        {
            if (!IsValidHand(hand) || IsTwoPair(hand) ||
                IsThreeOfAKind(hand) || IsStraight(hand) || IsFlush(hand) ||
                IsFullHouse(hand) || IsFourOfAKind(hand) || IsStraightFlush(hand))
            {
                return false;
            }

            var faces = new Dictionary<string, int>();
            foreach (var card in hand.Cards)
            {
                if (!faces.ContainsKey(card.Face.ToString()))
                {
                    faces.Add(card.Face.ToString(), 1);
                }
                else
                {
                    faces[card.Face.ToString()]++;
                }
            }

            foreach (var value in faces.Values)
            {
                if (value == 2)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            if (!IsValidHand(hand) || IsOnePair(hand) || IsTwoPair(hand) ||
                IsThreeOfAKind(hand) || IsStraight(hand) || IsFlush(hand) ||
                IsFullHouse(hand) || IsFourOfAKind(hand) || IsStraightFlush(hand))
            {
                return false;
            }

            return true;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
