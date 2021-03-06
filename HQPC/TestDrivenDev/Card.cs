﻿using System;
using System.Text;

namespace Poker
{
    public class Card : ICard
    {
        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("{0} of {1}", this.Face, this.Suit);
            return result.ToString();
        }
    }
}
