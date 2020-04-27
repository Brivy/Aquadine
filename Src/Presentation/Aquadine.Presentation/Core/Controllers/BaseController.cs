using Aquadine.Application.Abstractions.Mediator;
using Microsoft.AspNetCore.Mvc;

namespace Aquadine.Presentation.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
        protected readonly IQuerySender _querySender;

        public BaseController(IQuerySender querySender)
        {
            _querySender = querySender;
        }
    }
}