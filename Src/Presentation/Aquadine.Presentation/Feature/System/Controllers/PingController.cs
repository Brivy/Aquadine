using Aquadine.Application.Core.Interfaces.Mediator;
using Aquadine.Application.Features.System.Queries.Ping;
using Aquadine.Presentation.Core.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace Aquadine.Presentation.Feature.System.Controllers
{
    public class PingController : BaseController
    {
        public PingController(IQuerySender querySender) : base(querySender)
        {

        }

        /// <summary>
        /// Ping the application to check if everything is up and running
        /// </summary>
        [HttpGet]
        [SwaggerResponse(200, "API is up and running.")]
        [SwaggerResponse(500, "The API has encountered an error.")]
        public async Task<IActionResult> Index(CancellationToken cancellationToken = default)
        {
            var result = await _querySender.SendQueryAsync(new PingSystemQuery(), cancellationToken);

            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return Ok(result);
        }
    }
}