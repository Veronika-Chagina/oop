namespace OOP_ICT
{
    using System;
    using System.Collections.Generic;

    public class PlayerHand
    {
        private List<Card> cards;

        public PlayerHand(List<Card> dealtCards)
        {
            cards = dealtCards;
        }

        public void Print()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}