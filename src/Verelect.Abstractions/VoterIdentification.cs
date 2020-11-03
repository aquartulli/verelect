namespace Verelect.Abstractions
{
    public class VoterIdentification
    {
        public Passport? Passport { get; }

        public VoterIdentification(Passport passport)
        {
            Passport = passport;
        }
    }
}
