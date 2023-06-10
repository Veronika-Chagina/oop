namespace OOP_ICT
{
    public class Card
    {
        public string Suit { get; }
        public string Rank { get; }

        public Card(string rank, string suit)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return $"{Rank} {Suit}";
        }
    }
}