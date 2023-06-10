namespace OOP_ICT
{
    public class Dealer
    {
        public static Dealer instance = new Dealer(); 
        public Deck deck;

        public Dealer()
        {
            deck = new Deck();
            deck.Shuffle();
        }

        public static Dealer GetInstance()
        {
            return instance;
        }
        
        public List<Card> Deal()
        {
            List<Card> cards = deck.GetCards();
            deck.Shuffle();
            return cards;
        }
    }
}