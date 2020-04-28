using Aquadine.Application.Core.Interfaces.Mediator;
using Aquadine.Application.Features.System.Queries.Ping;
using Aquadine.Presentation.Core.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace Aquadine.Presentation.Feature.System.Controllers
{
    public class PingController : BaseController
    {
        public PingController(IQuerySender querySender) : base(querySender)
        {

        }

        [HttpGet]
        public async Task<IActionResult> Index(CancellationToken cancellationToken = default)
        {
            var result = await _querySender.SendQueryAsync(new PingSystemQuery(), cancellationToken);

            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}