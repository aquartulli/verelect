using System;
using Verelect.Abstractions;

namespace Verelect.Api.Public
{
    public class GetMyVoteRequestBody
    {
        public VoterIdentification VoterIdentification { get; }
        public Guid SecretKey { get; }

        public GetMyVoteRequestBody(VoterIdentification voterIdentification, Guid secretKey)
        {
            VoterIdentification = voterIdentification;
            SecretKey = secretKey;
        }
    }
}
