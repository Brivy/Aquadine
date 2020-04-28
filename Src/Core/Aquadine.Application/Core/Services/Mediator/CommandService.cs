using Aquadine.Application.Core.Interfaces.Mediator;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Aquadine.Application.Core.Services.Mediator
{
    internal class CommandService : ICommandSender
    {
        private readonly IMediator _mediator;

        public CommandService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task SendRequestAsync(IRequest command, CancellationToken cancellationToken)
        {
            await _mediator.Send(command, cancellationToken);
        }

        public async Task<TResponse> SendRequestAsync<TResponse>(IRequest<TResponse> command, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command, cancellationToken);
            return response;
        }
    }
}
