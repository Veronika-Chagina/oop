namespace OOP_ICT
{
    using System;
    using System.Collections.Generic;

    public class Deck
    {
        private readonly List<Card> cards;
        private static readonly Random rand = new Random(); 

        public Deck()
        {
            cards = new List<Card>();

            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suits = { "hearts", "diamonds", "spades", "clubs" };

            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                    Card card = new Card(ranks[j], suits[i]);
                    cards.Add(card);
                }
            }
        }
        
        public void Shuffle()
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                (cards[i], cards[j]) = (cards[j], cards[i]);
            }
        }

        public List<Card> GetCards()
        {
            return cards;
        }
    }
}