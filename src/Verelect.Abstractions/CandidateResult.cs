namespace Verelect.Abstractions
{
    public class CandidateResult
    {
        public Candidate Candidate { get; }
        public long Count { get; }

        public CandidateResult(Candidate candidate, long count)
        {
            Candidate = candidate;
            Count = count;
        }
    }
}
