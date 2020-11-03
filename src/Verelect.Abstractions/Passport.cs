namespace Verelect.Abstractions
{
    public class Passport
    {
        public string CardNumber { get; }

        public Passport(string cardNumber)
        {
            CardNumber = cardNumber;
        }
    }
}
