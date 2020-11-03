using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Verelect.Api.Public.Controllers
{
    [ApiController]
    [Route("races")]
    public class RacesController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<object>> GetRaces(CancellationToken cancellationToken)
        {
            return new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [HttpGet]
        [Route("{raceId:guid}/votes/my")]
        public async Task<ActionResult<object>> GetMyVoteAsync([FromRoute] Guid raceId, [FromBody] GetMyVoteRequestBody getMyVoteRequestBody, CancellationToken cancellationToken)
        {
            return new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [HttpGet]
        [Route("{raceId:guid}/votes")]
        public async Task<ActionResult<object>> GetResultsAsync([FromRoute] Guid raceId, CancellationToken cancellationToken)
        {
            var cdnUri = await GetCdnLinkForRaceResultsAsync(raceId, cancellationToken).ConfigureAwait(false);
            if (cdnUri == null)
            {
                return new NotFoundResult();
            }

            return new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        private ValueTask<Uri> GetCdnLinkForRaceResultsAsync(Guid raceId, CancellationToken cancellationToken)
        {
            return new ValueTask<Uri>(new Uri("https://www.google.com"));
        }
    }
}
