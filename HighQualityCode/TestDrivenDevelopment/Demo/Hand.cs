﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    { 
        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public IList<ICard> Cards { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var card in this.Cards)
            {
                sb.AppendFormat("{0} ", card.ToString());
            }

            return sb.ToString();
        }        
    }
}
