namespace OOP_ICT
{
    class Program
    {
        static void Main()
        {
            Dealer dealer = Dealer.GetInstance();
            dealer.Deal();
        }
    }
}